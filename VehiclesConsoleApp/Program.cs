using System;
using VehiclesLibrary.src;
using VehiclesLibrary.src.Enums;
using VehiclesLibrary.src.Vehicles;

namespace VehiclesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVehicleAmphibian();
            TestVehicleCar();
            TestVehiclePlane();
            TestVehicleShip();
        }

        private static void TestVehicleAmphibian()
        {
            Motor motor = new Motor(FuelType.Oil, 350);
            Amphibian amphibian = new Amphibian(2, 6, motor);

            amphibian.Move();

            amphibian.IncreaseSpeed(20);
            amphibian.IncreaseSpeed(10);
            amphibian.IncreaseSpeed(30);

            amphibian.GetIntoWater();

            amphibian.DecreaseSpeed(15);

            amphibian.GetOntoGround();

            amphibian.Stop();
        }

        private static void TestVehicleCar()
        {
            //Car car = new Car();
        }

        private static void TestVehiclePlane()
        {
            //Plane plane = new Plane();
        }

        private static void TestVehicleShip()
        {
            //Ship ship = new Ship();
        }
    }
}
