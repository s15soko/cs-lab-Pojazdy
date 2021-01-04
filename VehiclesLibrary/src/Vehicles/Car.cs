using VehiclesLibrary.src.Vehicles.Types;

namespace VehiclesLibrary.src.Vehicles
{
    public class Car : GroundVehicle
    {
        public Motor Motor { get; }
        public Car(Motor motor, int numberOfWheels = 4) : base(numberOfWheels: numberOfWheels)
        {
            Motor = motor;
        }
    }
}
