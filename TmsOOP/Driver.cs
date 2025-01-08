namespace TmsOOP;

public class Driver
{
    public string Name { get; private set; }
    public int Experience { get; private set; }
    public List<Category> Categories { get;private set; }
    public List<Transport> Transports { get; private set; }
    
    public Driver(string name, int experience, Category category, Transport transport)
    {
        Name = name;
        Experience = experience;
        Categories = new List<Category>();
        Transports = new List<Transport>();
        Categories.Add(category);
        Transports.Add(transport);
    }

    public Driver(string name, int experience, List<Category> categories, List<Transport> transports)
    {
        Name = name;
        Experience = experience;
        Categories = categories;
        Transports = transports;
    }

    public void AddCategories(params Category[] categories)
    {
        foreach (var item in categories)
        {
            if(!Categories.Contains(item))
                Categories.Add(item);
        }
    }
    // Проверить подходит ли тип транспорта по категории
    public void AddTransport(Transport transport)
    {
        if (transport != null && !Transports.Contains(transport))
        {
            Transports.Add(transport);
        }
    }
}