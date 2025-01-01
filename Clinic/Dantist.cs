namespace Clinic;

public class Dantist : IDoctor
{
    public void Treat(Patient patient)
    {
        Console.WriteLine($"Dantist treat {patient.Name}");
    }
}