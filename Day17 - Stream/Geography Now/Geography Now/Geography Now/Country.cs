public class Country : GeographicEntity
{
    public City CapitalCity { get; set; }
    public List<City> Cities { get; set; } = new List<City>();
    public int cnt = 0;
    public Country(string name, List<City> cities) : base(name)
    {
        if (cities == null || cities.Count == 0) 
            throw new CountryMustHaveAtLeastOneCity();

        cnt = 0;

        foreach (City city in cities)
        {
            if (cnt == 0 && city.IsCapital)
            {
                cnt++;
                CapitalCity = city;
            }
            else if (city.IsCapital)
            {
                throw new CountryMustHaveSingleCapital();
            }
            Population += city.Population;
            Area += city.Area;
            Cities.Add(city);
        }
    }
}