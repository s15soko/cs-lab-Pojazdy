using VehiclesLibrary.src.Enums;

namespace VehiclesLibrary.src
{
    public class WaterVehicle : VehicleBase
    {
        public double Displacement { get; }
        
        public WaterVehicle(double displacement) : base()
        {
            Environment = VehicleMovementEnvironment.Water;
            Displacement = displacement;
        }

        public override string ToString()
        {
            return $"Pojazd typu wodnego \n" +
                    $"Wyporność: {Displacement} \n" + 
                    base.ToString();
        }
    }
}
