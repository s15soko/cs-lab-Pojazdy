using System;

namespace VehiclesLibrary.src.Exceptions
{
    public class EnvironmentNotFound : Exception
    {
        public EnvironmentNotFound() { }

        public EnvironmentNotFound(string message) : base(message)
        { }

        public EnvironmentNotFound(string message, Exception inner) : base(message, inner)
        { }
    }
}
