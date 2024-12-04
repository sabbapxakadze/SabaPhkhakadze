// ქალაქის სახელი|ფართბი|მოსახლეობის რაოდენობა|არის თუ არა
//დედაქალაქი(true ან false) | ქვეყნის დასახელება რომელსაც ეკუთვნის.
//Paris | 105,4 | 2161000 | true | France
//Kutaisi | 67,7 | 147500 | false | Georgia
//London | 157,2 | 8982000 | true | England
//Grenoble | 18,13 | 160689 | false | France
//Liverpool | 111,8 | 486784 | false | England
//Tbilisi | 726 | 1114000 | true | Georgia


List<City> cities = new List<City>();
List<Country> countries = new List<Country>();

using (FileStream fs = new FileStream("cities.txt", FileMode.Open, FileAccess.Read))
{

    using (StreamReader sr = new StreamReader(fs))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] strings = line.Split('|');

            if (strings.Length != 5)
            {
                Console.WriteLine("Invalid line!");
                continue;
            }
            try
            {
                string cityName = strings[0];
                float area = float.Parse(strings[1].Replace(',', '.'));
                int population = int.Parse(strings[2]);
                bool isCapital = bool.Parse(strings[3]);
                string countryName = strings[4];

                City c = new City(cityName, population, area, isCapital, countryName);

                cities.Add(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

Dictionary<string, List<City>> dict = new Dictionary<string, List<City>>();

foreach (City city in cities)
{
    if (!dict.ContainsKey(city.CountryName))
    {
        dict.Add(city.CountryName, new List<City>());
    }
    dict[city.CountryName].Add(city);
}

foreach (var xy in dict)
{
    string countryName = xy.Key;
    List<City> cityList = xy.Value;

    try
    {
        Country country = new Country(countryName, cityList);
        countries.Add(country);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


Console.Write("Type 1 if you want to search countries, type 2 if you want to search cities: ");

int x = int.Parse(Console.ReadLine());

while (x != 1 && x != 2)
{
    Console.Write("Please type correct input: ");
}

if (x == 1)
{
    Console.Write("Enter the city name you are searching: ");
    string country = Console.ReadLine().ToLower();
    bool contains = false;
    List<City> cityList = new List<City>();

    foreach (var c in countries)
    {
        if (c.Name.ToLower() == country)
        {
            contains = true;
            cityList = c.Cities;
            Console.WriteLine($"{c.Name} has a population of {c.Population} and it's Area is {c.Area}^2 meter.");
            Console.WriteLine($"Here are the cities that belongs to {c.Name}");
        }
    }
    if (!contains)
    {
        Console.WriteLine("Given country does not exist in our system!");
    }
    else
    {
        foreach(var thiscity in cityList)
        {
            Console.Write($"{thiscity.Name} ");
            if (thiscity.IsCapital)
                Console.WriteLine("{Capital}");
            Console.WriteLine();
        }
    }
}
else
{
    Console.Write("Enter the city name you are searching: ");
    string city = Console.ReadLine().ToLower();

    bool contains = false;
    
    foreach(var c in cities)
    {
        if (c.Name.ToLower() == city)
        {
            contains = true;
            Console.Write($"{c.Name} belongs to {c.CountryName} and has {c.Population} population and Area is {c.Area}^2 meter. ");
            if (c.IsCapital)
                Console.WriteLine("This city is Capital.");
        }
    }
    if (!contains)
    {
        Console.WriteLine("Given city does not exists in our system!");
    }
}