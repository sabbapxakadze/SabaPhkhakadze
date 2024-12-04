public abstract class GeographicEntity
{
    public string Name { get; private set; }
    public int Population { get; set; }
    public double Area { get; set; }
    public GeographicEntity(string name)
    {
        Name = name;
    }
}