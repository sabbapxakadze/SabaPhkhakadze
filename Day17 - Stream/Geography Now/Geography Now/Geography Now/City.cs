public class City : GeographicEntity
{
    public bool IsCapital { get; set; }
    public string CountryName { get; set; }
    public City(string name, int population, float area, bool isCapital, string countryName) : base(name)
    {
        if (population < 0) throw new NegativePopulation();
        if (area <= 0f) throw new NegativeArea();
        Population = population;
        Area = area;
        IsCapital = isCapital;
        CountryName = countryName;

        //Console.WriteLine("We have a new City: {0}, Population: {1}, Area: {2}, IsCapital: {3}, CountryName: {4}",
          //      Name, population, area, isCapital, countryName
            //    );
    }
}