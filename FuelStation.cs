namespace Strategy_Checkpoint
{
  public class FuelStation
  {
    public string CalculateFuel(int current, int max, IVehicle vehicle)
    {
      var fuelConsumed = max - current;
      var cost = vehicle.FuelCost(fuelConsumed);
      return $"Fuel Consumed: {fuelConsumed}; Total Cost: {cost}";
    }
  }
}