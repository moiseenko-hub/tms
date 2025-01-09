namespace TmsOOP;

public class Category(string name, string description, int minimumAge, List<Transport> allowedTransports)
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public int MinimumAge { get; set; } = minimumAge;
    public List<Transport> AllowedTransports { get; set; } = allowedTransports;

    public string GetCategoryInfo()
    {
        return $"{Name} ({MinimumAge} лет): {Description}";
    }
    
}