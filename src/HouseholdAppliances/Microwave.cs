using static System.Console;
namespace HouseholdAppliances;

public class Microwave: Appliance, ICooker
{

   public int BoilingTime { get; set; }
   public int MaximumTemperature { get; set; }
    public Microwave(string brand, string model, int boilingTime, int maximumTemperature,  bool ison = false) : base(brand, model, ison)
    {
       BoilingTime = boilingTime;
       MaximumTemperature = maximumTemperature;

    }

    public void Cook(string food)
    {
      if(!IsOn) throw new ArgumentException("the microwave is off");
      WriteLine($"your {food} is in progress");
    }

    public void Heat(string food)
    {
      if(!IsOn) throw new ArgumentException("the microwave is off");
      WriteLine($"your {food} is being heated");
    }

}