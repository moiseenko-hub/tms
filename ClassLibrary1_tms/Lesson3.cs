namespace ClassLibrary1_tms;

public class Lesson3
{
    public void ShowSeasonSwitch(int num)
    {
        var result = num switch
        {
            1 => "Winter",
            2 => "Winter",
            3 => "Spring",
            4 => "Spring",
            5 => "Spring",
            6 => "Summer",
            7 => "Summer",
            8 => "Summer",
            9 => "Autumn",
            10 => "Autumn",
            11 => "Autumn",
            12 => "Winter",
            _ => "Error"
        };
        Console.WriteLine(result);
    }

    public void ShowSeasonIf(int num)
    {
        string result;
        if (num == 1)
            result = "Winter";
        else if (num == 2)
            result = "Winter";
        else if (num == 3)
            result = "Spring";
        else if (num == 4)
            result = "Spring";
        else if (num == 5)
            result = "Spring";
        else if (num == 6)
            result = "Summer";
        else if (num == 7)
            result = "Summer";
        else if (num == 8)
            result = "Summer";
        else if (num == 9)
            result = "Autumn";
        else if (num == 10)
            result = "Autumn";
        else if (num == 11)
            result = "Autumn";
        else if (num == 12)
            result = "Winter";
        else
            result = "Error";
        Console.WriteLine(result);
        
    }

    public void IsEven(int num)
    {
        Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
    }

    public void GetTemperatureDescription(int t)
    {
        if(t > -5)
            Console.WriteLine("Warm");
        else if (-5 >= t & t > -20)
            Console.WriteLine("Fine");
        else if(-20 >= t)
            Console.WriteLine("Cold");
    }

    public void ShowColorOfRainbow(int n)
    {
        Console.WriteLine(n switch
        {
            1 => "Red",
            2 => "Orange",
            3 => "Yellow",
            4 => "Green",
            5 => "Blue",
            6 => "Violet",
            _ => "Error"
        });
    }
}