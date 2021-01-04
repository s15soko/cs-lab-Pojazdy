using VehiclesLibrary.src.Enums;

namespace VehiclesLibrary.src.Interfaces
{
    public interface IVehicleBase
    {
        public double MinSpeed { get; set; }
        public double MaxSpeed { get; set; }
        public double CurrentSpeed { get; set; }
        public bool IsInMove { get; }

        public SpeedUnit SpeedUnit { get; set; }
        public VehicleState State { get; set; }

        public void Move();
        public void Stop();

        //

        public VehicleMovementEnvironment Environment { get; set; }

        public void IncreaseSpeed(double diff);

        public void DecreaseSpeed(double diff);
    }
}
