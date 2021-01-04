using VehiclesLibrary.src.Enums;
using VehiclesLibrary.src.Interfaces;

namespace VehiclesLibrary.src
{
    public class Motor : IMotor
    {
        public FuelType FuelType { get; }
        public int HorsePower { get; }

        public Motor(FuelType fuelType, int horsePower)
        {
            FuelType = fuelType;
            HorsePower = horsePower;
        }
    }
}
