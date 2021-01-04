using VehiclesLibrary.src.Enums;

namespace VehiclesLibrary.src.Vehicles
{
    public class Amphibian : VehicleBase
    {
        public double Displacement { get; }
        public int NumberOfWheels { get; }

        public Motor Motor { get; }

        public Amphibian(int displacement, int numberOfWheels, Motor motor)
        {
            Displacement = displacement;
            NumberOfWheels = numberOfWheels;
            Motor = motor;

            Environment = VehicleMovementEnvironment.Ground;
        }

        public void GetIntoWater()
        {
            Environment = VehicleMovementEnvironment.Water;
        }

        public void GetOntoGround()
        {
            Environment = VehicleMovementEnvironment.Ground;
        }
    }
}
