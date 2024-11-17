using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class PublicTransportVehicle : Vehicle, ITransport
    {
        public enum PublicTransport
        {
            Bus,
            Metro,
            Tram
        }

        public int MaxCapacity { get; private set; }
        public PublicTransport TransportType { get; private set; }
        private static int currentPassangers = 0;

        public PublicTransportVehicle(int maxSpeed, string fuelType, string color, 
            int maxCapacity, PublicTransport publicTransport, string mark, int releaseYear, string model) :
            base(maxSpeed, fuelType, color, mark, releaseYear, model)
        {
            MaxCapacity = maxCapacity;
            TransportType = publicTransport;
        }
        public override string ToString()
        {
            return $"We have a {TransportType} with max capacity {MaxCapacity}. " 
                + base.ToString();
        }

        public void DropPassenger()
        {
            if (currentPassangers != 0)
            Console.WriteLine($"Dropped a passenger. Now there are {currentPassangers} passenger in transport");
            else
            {
                Console.WriteLine("No passenger on a transport!");
            }
        }

        public void TakePassenger()
        {
            if (currentPassangers != MaxCapacity)
            {
                currentPassangers++;
                Console.WriteLine($"You took a passenger. Now there are {currentPassangers} in transport");
            }
        }
    }
}
