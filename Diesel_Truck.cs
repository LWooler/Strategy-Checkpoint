namespace Strategy_Checkpoint
{
  public class Diesel_Truck : IVehicle
  {
    public double FuelPrice = 3.19;
    public double FuelCost(int consumed)
    {
      return FuelPrice * consumed;
    }
  }
}