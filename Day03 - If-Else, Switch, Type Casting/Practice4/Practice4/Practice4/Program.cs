Console.WriteLine("Enter your birth year:");

int y = int.Parse(Console.ReadLine());

string year = "";

switch (y%12)
{
    case 0:
        year = "Monkey";
        break;
    case 1:
        year = "Rooster";
        break;
    case 2:
        year = "Dog";
        break;
    case 3:
        year = "Pig";
        break;
    case 4:
        year = "Rat";
        break;
    case 5:
        year = "Bull";
        break;
    case 6:
        year = "Tiger";
        break;
    case 7:
        year = "Rabbit";
        break;
    case 8:
        year = "Dragon";
        break;
    case 9:
        year = "Snake";
        break;
    case 10:
        year = "Horse";
        break;
    case 11:
        year = "Sheep";
        break;
}

Console.WriteLine($"{y} is {year} year");