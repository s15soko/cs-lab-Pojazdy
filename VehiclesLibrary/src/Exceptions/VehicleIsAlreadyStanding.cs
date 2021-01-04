using System;

namespace VehiclesLibrary.src.Exceptions
{
    public class VehicleIsAlreadyStanding : Exception
    {
        public VehicleIsAlreadyStanding() { }

        public VehicleIsAlreadyStanding(string message) : base(message)
        { }

        public VehicleIsAlreadyStanding(string message, Exception inner) : base(message, inner)
        { }
    }
}
