namespace HouseholdAppliances.Test;

public class ApplianceTests
{
    public static TheoryData<object, object> PolymorphismData => new TheoryData<object, object>
    {
        {
            new Microwave("Samsung", "MW-01", 5, 100),
            new ElectricStove("Electrolux", "ST-02", 10, 200)
        },
    };

    [Theory]
    [InlineData("Samsung", "ST-01", 5, 100, false)]
    [InlineData("Electrolux", "ST-02", 10, 200, false)]
    public void TestMicrowave(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var instaceM = new Microwave(brand, model, boilingTime, maximumTemperature, initialIsOn);
        instaceM.IsOn.Should().Be(initialIsOn);
        instaceM.Brand.Should().Be(brand);
        instaceM.Model.Should().Be(model);
        instaceM.BoilingTime.Should().Be(boilingTime);
        instaceM.MaximumTemperature.Should().Be(maximumTemperature);
        instaceM.SwitchPower().Should().Be(true);

        Action act = () => instaceM.Cook("frango");
        act.Should().Throw<Exception>().WithMessage("the microwave is off");

         Action actMicrowave = () => instaceM.Heat("frango");
         actMicrowave.Should().Throw<Exception>().WithMessage("the microwave is off");
    }

    [Theory]
    [InlineData("Samsung", "MW-01", 5, 100, false)]
    [InlineData("Electrolux", "MW-02", 10, 200, false)]
    public void TestElectricStove(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var instaceM = new ElectricStove(brand, model, boilingTime, maximumTemperature, initialIsOn);
        instaceM.IsOn.Should().Be(initialIsOn);
        instaceM.Brand.Should().Be(brand);
        instaceM.Model.Should().Be(model);
        instaceM.BoilingTime.Should().Be(boilingTime);
        instaceM.MaximumTemperature.Should().Be(maximumTemperature);
        instaceM.SwitchPower().Should().Be(true);

        Action act = () => instaceM.Cook("frango");
        act.Should().Throw<Exception>().WithMessage("the stove is not handled");

         Action actMicrowave = () => instaceM.Bake("frango");
         actMicrowave.Should().Throw<Exception>().WithMessage("the oven is not on");
    }

    [Theory]
    [MemberData(nameof(PolymorphismData))]
    public void TestPolymorphism(object microwave, object electricStove)
    {
        

    microwave.Should().BeAssignableTo<Appliance>();
    microwave.Should().BeAssignableTo<ICooker>();
    electricStove.Should().BeAssignableTo<Appliance>();
    electricStove.Should().BeAssignableTo<ICooker>();
    }
}