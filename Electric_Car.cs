namespace Strategy_Checkpoint
{
    public class Electric_Car : IVehicle
    {
        public double FuelPrice = 1.24;
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