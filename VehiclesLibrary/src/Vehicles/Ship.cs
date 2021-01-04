namespace VehiclesLibrary.src.Vehicles
{
    public class Ship : WaterVehicle
    {
        public Motor Motor { get; }
        public Ship(int displacement, Motor motor) : base(displacement: displacement)
        {
            Motor = motor;
        }
    }
}
