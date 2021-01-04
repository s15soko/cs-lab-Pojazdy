using VehiclesLibrary.src.Enums;
using VehiclesLibrary.src.Exceptions;
using VehiclesLibrary.src.Interfaces;

namespace VehiclesLibrary.src
{
    public abstract class VehicleBase : IVehicleBase
    {
        private double _currentSpeed = 0;
        private VehicleMovementEnvironment _environment;

        //

        public double MinSpeed { get; set; }
        public double MaxSpeed { get; set; }
        public double CurrentSpeed { 
            get
            {
                return _currentSpeed;
            }
            set
            {
                if (!IsInMove)
                    return;

                if (value < MinSpeed)
                    _currentSpeed = MinSpeed;
                if (value > MaxSpeed)
                    _currentSpeed = MaxSpeed;
                else _currentSpeed = value;
            } 
        }

        public bool IsInMove => State == VehicleState.InMove;

        public SpeedUnit SpeedUnit { get; set; }
        public VehicleState State { get; set; }
        public VehicleMovementEnvironment Environment 
        {
            get
            {
                return _environment;
            }
            set
            {
                _environment = value;
                OnEnvironmentChanged();
            }
        }

        public VehicleBase()
        {
            State = VehicleState.Stand;
        }

        public void DecreaseSpeed(double diff)
        {
            if (!IsInMove)
                throw new VehicleIsAlreadyStanding();

            CurrentSpeed -= diff;
        }

        public void IncreaseSpeed(double diff)
        {
            if (!IsInMove)
                throw new VehicleIsAlreadyStanding();

            CurrentSpeed += diff;
        }

        public void Start()
        {
            if (IsInMove)
                throw new VehicleIsAlreadyMoving();

            CurrentSpeed = MinSpeed;
            State = VehicleState.InMove;
        }

        public void Stop()
        {
            if (!IsInMove)
                throw new VehicleIsAlreadyStanding();

            CurrentSpeed = 0;
            State = VehicleState.Stand;
        }

        protected void OnEnvironmentChanged()
        {
            switch (Environment)
            {
                case VehicleMovementEnvironment.Ground:
                    MinSpeed = 1;
                    MaxSpeed = 350;
                    SpeedUnit = SpeedUnit.KmPerHour;
                    return;
                case VehicleMovementEnvironment.Water:
                    MinSpeed = 1;
                    MaxSpeed = 40;
                    SpeedUnit = SpeedUnit.NauticalMile;
                    return;
                case VehicleMovementEnvironment.Air:
                    MinSpeed = 20;
                    MaxSpeed = 200;
                    SpeedUnit = SpeedUnit.MPerSecond;
                    return;
                default:
                    throw new EnvironmentNotFound();
            }
        }

        public override string ToString()
        {
            return $"Aktualne środowisko: {Environment} \n" +
                    $"Stan pojazdu: {State} i aktualna prędkość: {CurrentSpeed} \n" +
                    $"Minimalna prędkość: {MinSpeed} oraz maksymalna prędkość: {MaxSpeed}. \n";
        }
    }
}
