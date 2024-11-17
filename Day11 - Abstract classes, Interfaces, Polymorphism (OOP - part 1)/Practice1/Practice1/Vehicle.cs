using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    abstract class Vehicle
    {
        public int MaxSpeed { get; private set; }
        public string FuelType { get; private set; }
        public string Color { get; private set; }
        public string Mark { get; private set; }
        public string Model { get; private set; }
        public int ReleaseYear { get; private set; }

        public Vehicle(int maxSpeed, string fuelType, 
            string color, string mark, int releaseYear, string model)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
            Color = color;
            Mark = mark;
            ReleaseYear = releaseYear;
            Model = model;
        }

        public virtual string ToString()
        {
            return $"This vehicle is {Mark} {Model} with max speed of: {MaxSpeed}, " +
                $"fuel type is {FuelType}, " +
                $" also it's color is {Color}";
        }
        public void Drive()
        {
            Console.WriteLine("You are driving.");
        }
        public void StopDrive()
        {
            Console.WriteLine("You stopped driving.");
        }
    }
}