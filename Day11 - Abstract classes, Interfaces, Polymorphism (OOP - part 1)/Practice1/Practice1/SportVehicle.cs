using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class SportVehicle : Vehicle, ISport
    {
        public enum SportVehicleType
        {
            F1,
            Rally,
            OffRoad
        }

        public int HorsePower { get; private set; }
        public double ZeroToHundreed { get; private set; }
        public SportVehicleType VehicleType { get; private set; }

        public SportVehicle(int maxSpeed, string fuelType, string color,
            int horsePower, double zeroToHundreed, SportVehicleType vehicleType,
            string mark, int releaseYear, string model)
            : base(maxSpeed, fuelType, color, mark, releaseYear, model)
        {
            HorsePower = horsePower;
            ZeroToHundreed = zeroToHundreed;
            VehicleType = vehicleType;
        }

        public override string ToString()
        {
            return $"This is a {VehicleType} with {HorsePower} HP, " +
                   $"a 0-100 time of {ZeroToHundreed} seconds, and a top speed of {MaxSpeed} km/h. " +
                   base.ToString();
        }

        public void Drift()
        {
            Drive();
            Console.WriteLine($"You are drifting in your {Mark} {Model}.");
        }

        public void FullAccelerate()
        {
            Drive();
            Console.WriteLine($"Huuraaayyyy! You are going max speed {MaxSpeed} km/h!");
        }
    }
}
