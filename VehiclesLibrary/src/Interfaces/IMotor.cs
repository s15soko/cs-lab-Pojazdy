using VehiclesLibrary.src.Enums;

namespace VehiclesLibrary.src.Interfaces
{
    public interface IMotor
    {
        public FuelType FuelType { get; }
        public int HorsePower { get; }
    }
}
