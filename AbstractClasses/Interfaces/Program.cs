using System;

namespace MovableApp
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            car.Move();

            IMovable bicycle = new Bicycle();
            bicycle.Move();

            Console.ReadLine();
        }
    }
}
