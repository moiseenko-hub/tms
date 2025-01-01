namespace Clinic;

public class Surgeon : IDoctor
{
    public void Treat(Patient patient)
    {
        Console.WriteLine($"Surgeon treat {patient.Name}");
    }
}