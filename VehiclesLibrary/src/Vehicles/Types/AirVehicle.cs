using VehiclesLibrary.src.Enums;

namespace VehiclesLibrary.src.Vehicles.Types
{
    public class AirVehicle : VehicleBase
    {
        public AirVehicle() : base()
        {
            Environment = VehicleMovementEnvironment.Ground;
        }

        public new void Stop()
        {
            if (Environment == VehicleMovementEnvironment.Air)
            {
                return;
            }

            base.Stop();
        }

        public void Land()
        {
            Environment = VehicleMovementEnvironment.Ground;
        }

        public void TakeOff()
        {
            Environment = VehicleMovementEnvironment.Air;
        }

        public override string ToString()
        {
            return $"Pojazd typu powietrznego \n" +
                    base.ToString();
        }
    }
}
