namespace Clinic;

public class Therapist : IDoctor
{
    public void Treat(Patient patient)
    {
        Console.WriteLine($"Therapist treat {patient.Name}");
    }
}