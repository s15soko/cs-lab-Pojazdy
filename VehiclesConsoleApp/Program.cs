﻿using System;
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

            amphibian.Start();

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
            Motor motor = new Motor(FuelType.LPG, 500);
            Car car = new Car(motor);
        }

        private static void TestVehiclePlane()
        {
            Motor motor = new Motor(FuelType.Gasoline, 500);
            Plane plane = new Plane(motor);
        }

        private static void TestVehicleShip()
        {
            Motor motor = new Motor(FuelType.Electricity, 600);
            Ship ship = new Ship(50, motor);
        }
    }
}
