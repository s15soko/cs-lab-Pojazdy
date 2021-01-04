using System;

namespace VehiclesLibrary.src.Exceptions
{
    public class VehicleIsAlreadyMoving : Exception
    {
        public VehicleIsAlreadyMoving() { }

        public VehicleIsAlreadyMoving(string message) : base(message)
        { }

        public VehicleIsAlreadyMoving(string message, Exception inner) : base(message, inner)
        { }
    }
}
