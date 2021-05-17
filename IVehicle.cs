namespace Strategy_Checkpoint
{
    public interface IVehicle
    {
        double FuelCost(int consumed);
        int FuelConsumed(int currentCap, int maxCap);
    }
}