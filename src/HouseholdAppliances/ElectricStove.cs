using static System.Console;
namespace HouseholdAppliances;

public class ElectricStove : Appliance, ICooker
{


    public int MaximumTemperature { get; set; }
    public int BoilingTime { get; set; }


    public ElectricStove(
        string brand, string model, int maximumTemperature,
        int boilingTime, bool Ison = false) : base(brand, model, Ison)
    {
        MaximumTemperature = maximumTemperature;
        BoilingTime = boilingTime;
    }


    public void Cook(string food)
    {
        if (!IsOn) throw new Exception("the stove is not handled");
        WriteLine($"your {food} is in progress");
    }


    public void Bake(string food)
    {
        if (!IsOn) throw new Exception("o forno não esta ligado");
        WriteLine($"o {food} esta assando");
    }
}