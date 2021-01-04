using VehiclesLibrary.src.Enums;

namespace VehiclesLibrary.src.Vehicles.Types
{
    public class GroundVehicle : VehicleBase
    {
        public int NumberOfWheels { get; }

        public GroundVehicle(int numberOfWheels) : base()
        {
            Environment = VehicleMovementEnvironment.Ground;
            NumberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
            return $"Pojazd typu lądowego \n" +
                    $"Liczba kół: {NumberOfWheels} \n" +
                    base.ToString();
        }
    }
}
