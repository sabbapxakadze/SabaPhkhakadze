using Practice1;

Console.WriteLine("Please choose what type of your Vehicle should be");
Console.Write("War, Sport, Transport or Consumer? Type your Preferrence: ");

string _vehType = Console.ReadLine();
string vehType = _vehType.ToLower();
while (vehType != "war" && vehType != "sport" && vehType != "transport" && vehType != "consumer")
{
    Console.Write("Please choose what type of your Vehicle should be correctly: ");
    vehType = Console.ReadLine();
    vehType = vehType.ToLower();
}

Console.Write("Enter your vehicle Mark: ");
string mark = Console.ReadLine();
Console.Write("Enter your vehicle Model: ");
string model = Console.ReadLine();
Console.Write("Enter your vehicle Color: ");
string color = Console.ReadLine();
Console.Write("Enter release year: ");
int releaseYear = int.Parse(Console.ReadLine());
Console.Write("Enter max speed: ");
int maxSpeed = int.Parse(Console.ReadLine());
Console.Write("Enter FuelType: ");
string fuelType = Console.ReadLine();

// FIRST I CHECK IF IT IS A WAR CAR INPUT TYPE
if (vehType == "war")
{
    Console.WriteLine("You can choose Tank, BTR or Humvee");
    string type = Console.ReadLine();
    type = type.ToLower();
    while (type != "tank" && type != "btr" && type != "humvee")
    {
        Console.Write("Enter a correct war car type: ");
        type = Console.ReadLine();
        type = type.ToLower();
    }
    WarVehicle.WarCarType carType = 0;
    switch (type)
    {
        case "tank": carType = WarVehicle.WarCarType.Tank; break;
        case "btr": carType = WarVehicle.WarCarType.BTR; break;
        case "humvee": carType = WarVehicle.WarCarType.Humvee; break;
    }

    Console.Write("Enter max damage: ");
    int maxDamage = int.Parse(Console.ReadLine());
    Console.Write("Enter Armour Level: ");
    int armourLevel = int.Parse(Console.ReadLine());
    Console.Write("Enter crew capacity: ");
    int crewCapacity = int.Parse(Console.ReadLine());

    WarVehicle veh = new WarVehicle(maxSpeed, fuelType, color, maxDamage, armourLevel, crewCapacity, carType,
            mark, releaseYear, model
        );

    Console.WriteLine("Now you can use Functionalities like Drive, StopDrive, Fight, TakeDamage and Repair and to stop working, type exit");
    string input = Console.ReadLine();
    while (input != "exit")
    {
        if (input.ToLower() == "drive")
        {
            veh.Drive();
        }
        else if (input.ToLower() == "stopdrive")
        {
            veh.StopDrive();
        }
        else if (input.ToLower() == "fight")
        {
            veh.Fight();
        }
        else if (input.ToLower() == "takedamage")
        {
            veh.TakeDamage();
        }
        else if (input.ToLower() == "repair")
        {
            veh.Repair();
        }
        input = Console.ReadLine();
    }
}
// SECOND I CHECK IF ITS SPORT CAR TYPE
else if (vehType == "sport")
{
    Console.WriteLine("You can choose F1, Rally or OffRoad");
    string type = Console.ReadLine();
    type = type.ToLower();
    while (type != "f1" && type != "rally" && type != "offroad")
    {
        Console.Write("Enter a correct sport car type: ");
        type = Console.ReadLine();
        type = type.ToLower();
    }

    SportVehicle.SportVehicleType carType = 0;
    switch (type)
    {
        case "f1": carType = SportVehicle.SportVehicleType.F1; break;
        case "rally": carType = SportVehicle.SportVehicleType.Rally; break;
        case "offroad": carType = SportVehicle.SportVehicleType.OffRoad; break;
    }

    Console.Write("Enter horsepower: ");
    int horsePower = int.Parse(Console.ReadLine());
    Console.Write("Enter 0-100 time: ");
    double zeroToHundreed = double.Parse(Console.ReadLine());

    SportVehicle veh = new SportVehicle(maxSpeed, fuelType, color, horsePower, zeroToHundreed, carType,
            mark, releaseYear, model);

    Console.WriteLine("Now you can use Functionalities like Drift, FullAccelerate, and to stop working, type exit");
    string input = Console.ReadLine();
    while (input != "exit")
    {
        if (input.ToLower() == "drift")
        {
            veh.Drift();
        }
        else if (input.ToLower() == "fullaccelerate")
        {
            veh.FullAccelerate();
        }
        input = Console.ReadLine();
    }
}

//THIRD.... 
else if (vehType == "consumer")
{
    Console.WriteLine("You can choose Sedan, Motorbike, Jeep, SUV, or Bike");
    string type = Console.ReadLine();
    type = type.ToLower();
    while (type != "sedan" && type != "motorbike" && type != "jeep" && type != "suv" && type != "bike")
    {
        Console.Write("Enter a correct consumer car type: ");
        type = Console.ReadLine();
        type = type.ToLower();
    }

    ConsumerVehicle.ConsumerVehicleType carType = 0;
    switch (type)
    {
        case "sedan": carType = ConsumerVehicle.ConsumerVehicleType.Sedan; break;
        case "motorbike": carType = ConsumerVehicle.ConsumerVehicleType.Motorbike; break;
        case "jeep": carType = ConsumerVehicle.ConsumerVehicleType.Jeep; break;
        case "suv": carType = ConsumerVehicle.ConsumerVehicleType.Suv; break;
        case "bike": carType = ConsumerVehicle.ConsumerVehicleType.Bike; break;
    }

    Console.Write("Enter passenger capacity: ");
    int passengerCapacity = int.Parse(Console.ReadLine());

    ConsumerVehicle veh = new ConsumerVehicle(maxSpeed, fuelType, color, passengerCapacity, carType,
            mark, releaseYear, model);

    Console.WriteLine("Now you can use Functionalities like RideWithFriends, GoShopping, GetStuckInTraffic, and to stop working, type exit");
    string input = Console.ReadLine();
    while (input != "exit")
    {
        if (input.ToLower() == "ridewithfriends")
        {
            veh.RideWithFriends();
        }
        else if (input.ToLower() == "goshopping")
        {
            veh.GoShopping();
        }
        else if (input.ToLower() == "getstuckintraffic")
        {
            veh.GetStuckInTraffic();
        }
        input = Console.ReadLine();
    }
}
//Lastttttttttttttttttttttttttttt!
else if (vehType == "transport")
{
    Console.WriteLine("You can choose Bus, Metro, or Tram");
    string type = Console.ReadLine();
    type = type.ToLower();
    while (type != "bus" && type != "metro" && type != "tram")
    {
        Console.Write("Enter a correct transport type: ");
        type = Console.ReadLine();
        type = type.ToLower();
    }

    PublicTransportVehicle.PublicTransport transportType = 0;
    switch (type)
    {
        case "bus": transportType = PublicTransportVehicle.PublicTransport.Bus; break;
        case "metro": transportType = PublicTransportVehicle.PublicTransport.Metro; break;
        case "tram": transportType = PublicTransportVehicle.PublicTransport.Tram; break;
    }

    Console.Write("Enter max capacity: ");
    int maxCapacity = int.Parse(Console.ReadLine());

    PublicTransportVehicle veh = new PublicTransportVehicle(maxSpeed, fuelType, color, maxCapacity, transportType,
            mark, releaseYear, model);

    Console.WriteLine("Now you can use Functionalities like DropPassenger, TakePassenger, and to stop working, type exit");
    string input = Console.ReadLine();
    while (input != "exit")
    {
        if (input.ToLower() == "droppassenger")
        {
            veh.DropPassenger();
        }
        else if (input.ToLower() == "takepassenger")
        {
            veh.TakePassenger();
        }
        input = Console.ReadLine();
    }
}