namespace TmsOOP;

public class Car : Transport
{
    public int NumberOfDoors { get; set; }
    
    //  Вынести в отдельный класс - слишком много
    public Car(string model, double maxSpeed, int passengerCapacity, string engineType, string color, int yearOfManufacture, string registrationNumber, int numberOfDoors)
        : base(model, "Легковой", maxSpeed, passengerCapacity, engineType, color, yearOfManufacture, registrationNumber)
    {
        NumberOfDoors = numberOfDoors;
    }
    
    public override string ToString()
    {
        return $"{Model} ({Type}): Максимальная скорость - {MaxSpeed} км/ч, Вместимость - {PassengerCapacity} пассажиров, Дверей - {NumberOfDoors}.";
    }
}