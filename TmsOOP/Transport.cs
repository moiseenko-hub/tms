namespace TmsOOP;

public abstract class Transport
{
     protected Transport(string model, string type, double maxSpeed, int passengerCapacity, string engineType, string color, int yearOfManufacture, string registrationNumber)
     {
          Model = model;
          Type = type;
          MaxSpeed = maxSpeed;
          PassengerCapacity = passengerCapacity;
          EngineType = engineType;
          Color = color;
          YearOfManufacture = yearOfManufacture;
          RegistrationNumber = registrationNumber;
     }

     public string Model { get; set; }
     public string Type { get; set; }
     public double MaxSpeed { get; set; }
     public int PassengerCapacity { get; set; }
     public string EngineType { get; set; }
     public string Color { get; set; }
     public int YearOfManufacture { get; set; }
     public string RegistrationNumber { get; set; }
     
     
     
}