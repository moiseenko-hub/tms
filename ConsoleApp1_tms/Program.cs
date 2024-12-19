using Calculator;
using ClassLibrary1_tms;

namespace ConsoleApp1_tms;

class Program
{
    static void Main(string[] args)
    {
        IStrategy strategy;
        StrategyContext strategyContext = new StrategyContext();
        Console.WriteLine("Choose the first number : ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose the second number : ");
        var b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose operation");
        var op = Console.ReadLine();

        strategy = op switch
        {
            "+" => new StrategyAdd(),
            "-" => new StrategySub(),
            "*" => new StrategyMult(),
            "/" => new StrategyDiv(),
            _ => throw new ArgumentOutOfRangeException()
        };
        
        strategyContext.SetStrategy(strategy);
        Console.WriteLine(strategyContext.ExecuteStrategy(a, b));
    }
}