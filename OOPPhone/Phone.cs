namespace OOPPhone;

public class Phone(string number, string model, float wight = 0)
{
    private string Number { get; set; } = number;
    public string Model { get; private set; } = model;
    public float Wight { get; private set; } = wight;
    
    public Phone() : this("Unknown", "Unknown", 0){ }

    public void ReceiveCall(string name)
    {
        Console.WriteLine($"Called : {name}");
    }

    public void ReceiveCall(string name, string number)
    {
        Console.WriteLine($"Called : {name}, number : {number}");
    }

    public void SendMessage(params string[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
    public string GetNumber()
    {
        return Number;
    }
}