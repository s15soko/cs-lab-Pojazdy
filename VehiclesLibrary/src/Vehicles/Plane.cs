namespace VehiclesLibrary.src.Vehicles
{
    public class Plane : AirVehicle
    {
        public Motor Motor { get; }

        public Plane(Motor motor)
        {
            Motor = motor;
        }
    }
}
