using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class ConsumerVehicle : Vehicle, IConsumer
    {
        public enum ConsumerVehicleType
        {
            Sedan,
            Motorbike,
            Jeep,
            Suv,
            Bike
        }

        public int PassengerCapacity { get; private set; }
        public ConsumerVehicleType VehicleType { get; private set; }

        public ConsumerVehicle(int maxSpeed, string fuelType, string color,
            int passengerCapacity, ConsumerVehicleType vehicleType,
            string mark, int releaseYear, string model)
            : base(maxSpeed, fuelType, color, mark, releaseYear, model)
        {
            PassengerCapacity = passengerCapacity;
            VehicleType = vehicleType;
        }

        public override string ToString()
        {
            return $"This is a {VehicleType} with a passenger capacity of {PassengerCapacity}. " 
                + base.ToString();
        }

        public void RideWithFriends()
        {
            Drive();
            Console.WriteLine("Yay, you are vibing in your car with friends!");
        }

        public void GoShopping()
        {
            Drive();
            Console.WriteLine($"Now you are Going Shopping with your {VehicleType}");
        }

        public void GetStuckInTraffic()
        {
            StopDrive();
            Console.WriteLine("You are stuck in a traffic :(");
        }
    }
}
