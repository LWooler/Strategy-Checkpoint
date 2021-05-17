namespace Strategy_Checkpoint
{
    public class Car : IVehicle
    {
        public double FuelPrice = 2.96;
        public double FuelCost(int consumed)
        {
            return FuelPrice * consumed;
        }

        public int FuelConsumed(int currentCap, int maxCap)
        {
            return maxCap - currentCap;
        }
    }
}