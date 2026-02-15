using System;
using System.Collections.Generic;

namespace VehicleSystem
{
    public interface IRefuelable
    {
        void Refill();
    }

    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        protected Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public abstract void Move();
    }

    public class Car : Vehicle, IRefuelable
    {
        public Car(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"The car {Brand} is driving on the road at a speed of {Speed} km/h.");
        }

        public void Refill()
        {
            Console.WriteLine($"The car {Brand} has been refueled with gasoline.");
        }
    }

    public class Bicycle : Vehicle
    {
        public Bicycle(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"The bicycle {Brand} is rolling along the path at a speed of {Speed} km/h.");
        }
    }

    public class Airplane : Vehicle, IRefuelable
    {
        public Airplane(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"The airplane {Brand} is flying in the sky at a speed of {Speed} km/h.");
        }

        public void Refill()
        {
            Console.WriteLine($"The airplane {Brand} has been refueled with aviation fuel.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("RAM", 120),
                new Bicycle("Giant", 25),
                new Airplane("Boeing", 900)
            };

            Console.WriteLine("--- Executing Move() method ---");
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }

            Console.WriteLine("--- Interface check (Refueling) ---");
            foreach (var vehicle in vehicles)
            {
                if (vehicle is IRefuelable refuelableVehicle)
                {
                    refuelableVehicle.Refill();
                }
                else
                {
                    Console.WriteLine($"{vehicle.Brand} does not require fuel (it is a bicycle).");
                }
            }
        }
    }
}