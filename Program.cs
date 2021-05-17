using System;

namespace Strategy_Checkpoint
{
  class Program
  {
    static void Main(string[] args)
    {
      FuelStation SevEleven = new FuelStation();
      Console.WriteLine(SevEleven.CalculateFuel(30, 1200, new Jet()));
      Console.WriteLine(SevEleven.CalculateFuel(4, 12, new Car()));
      Console.WriteLine(SevEleven.CalculateFuel(2, 30, new Diesel_Truck()));
      Console.WriteLine(SevEleven.CalculateFuel(1, 10, new Electric_Car()));
    }
  }
}
