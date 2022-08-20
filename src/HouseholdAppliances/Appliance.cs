namespace HouseholdAppliances;

public abstract class Appliance
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool IsOn { get; set; }

    
    public Appliance(string brand, string model, bool Ison)
    {
        Brand = brand;
        Model = model;
        IsOn = Ison;
    }
}