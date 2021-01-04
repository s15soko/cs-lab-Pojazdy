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
                System.Console.WriteLine("The vehicle can not land.");
                return;
            }

            base.Stop();
        }

        public void Land()
        {
            Environment = VehicleMovementEnvironment.Ground;
            System.Console.WriteLine("The vehicle landed.");
            OnEnvironmentChanged();
        }

        public void TakeOff()
        {
            Environment = VehicleMovementEnvironment.Air;
            OnEnvironmentChanged();
        }

        public override string ToString()
        {
            return $"Pojazd typu powietrznego \n" +
                    base.ToString();
        }
    }
}
