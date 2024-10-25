Console.WriteLine("Enter your day of birth:");
int day = int.Parse(Console.ReadLine());

while (day < 0 || day > 31)
{
    Console.WriteLine("Choose a correct day");
    day = int.Parse(Console.ReadLine());
}

Console.WriteLine("Enter your month of birth in a lower case");
string month = Console.ReadLine();


string horoscope = "";

switch (month)
{
    case "january":
        if (day <= 19) horoscope = "Capricorn";
        else horoscope = "Aquarius";
        break;

    case "february":
        if (day <= 18) horoscope = "Aquarius";
        else if (day <= 29) horoscope = "Pisces";
        else Console.WriteLine("Invalid day for February.");
        break;

    case "march":
        if (day <= 20) horoscope = "Pisces";
        else horoscope = "Aries";
        break;

    case "april":
        if (day <= 19) horoscope = "Aries";
        else horoscope = "Taurus";
        break;

    case "may":
        if (day <= 20) horoscope = "Taurus";
        else horoscope = "Gemini";
        break;

    case "june":
        if (day <= 20) horoscope = "Gemini";
        else horoscope = "Cancer";
        break;

    case "july":
        if (day <= 22) horoscope = "Cancer";
        else horoscope = "Leo";
        break;

    case "august":
        if (day <= 22) horoscope = "Leo";
        else horoscope = "Virgo";
        break;

    case "september":
        if (day <= 22) horoscope = "Virgo";
        else horoscope = "Libra";
        break;

    case "october":
        if (day <= 22) horoscope = "Libra";
        else horoscope = "Scorpio";
        break;

    case "november":
        if (day <= 21) horoscope = "Scorpio";
        else horoscope = "Sagittarius";
        break;

    case "december":
        if (day <= 21) horoscope = "Sagittarius";
        else horoscope = "Capricorn";
        break;

    default:
        Console.WriteLine("Invalid month entered.");
        return;
}

if (string.IsNullOrEmpty(horoscope))
    Console.WriteLine("Invalid input");
else
    Console.WriteLine($"{day} {month} is {horoscope}");


