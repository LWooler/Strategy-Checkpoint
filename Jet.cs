namespace Strategy_Checkpoint
{
  public class Jet : IVehicle
  {
    public double FuelPrice = 170.00;
    public double FuelCost(int consumed)
    {
      return FuelPrice * consumed;
    }
  }
}