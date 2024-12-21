using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class WarVehicle : Vehicle, IWarVehicle
    {
        public enum WarCarType
        {
            Tank,
            BTR,
            Humvee
        }
        public int MaxDamage { get; private set; }
        public int ArmourLevel { get; private set; }
        private static int maxArmourLevel;
        public int CrewCapacity { get; private set; }
        public WarCarType WarTypeCar { get; private set; }
        public WarVehicle(int maxSpeed, string fuelType, string color,
            int maxDamage, int armourLevel, int crewCapacity, WarCarType warTypeCar,
            string mark, int releaseYear, string model) 
            : base(maxSpeed, fuelType, color, mark, releaseYear, model)
        {
            MaxDamage = maxSpeed;
            ArmourLevel = armourLevel;
            CrewCapacity = crewCapacity;
            WarTypeCar = warTypeCar;
            maxArmourLevel = armourLevel;
        }    
        public override string ToString()
        {
            return $"We have a {WarTypeCar} with crew capacity {CrewCapacity}." +
                $"It can give a damage up to {MaxDamage} and has an armour of {ArmourLevel} maximal damage. "
                + base.ToString();
        }

        public void Fight()
        {
            Random r = new Random();
            int damage = r.Next(1, MaxDamage);
            Console.WriteLine($"Your damage was {damage}");
        }

        public void TakeDamage()
        {
            Random r = new Random();
            int damage = r.Next(1, ArmourLevel);
            ArmourLevel -= damage;
            Console.WriteLine($"You dealt with {damage} damage. Now you have {ArmourLevel} left.");
        }

        public void Repair()
        {
            ArmourLevel += 100;
            if ( ArmourLevel > maxArmourLevel ) ArmourLevel = maxArmourLevel;
            Console.WriteLine($"Now your armour is {ArmourLevel}");
        }
    }
}