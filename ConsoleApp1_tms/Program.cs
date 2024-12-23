using Calculator;
using ClassLibrary1_tms;

namespace ConsoleApp1_tms;

class Program
{
    static void Main(string[] args)
    {
        IArithmeticStrategy? arithmeticStrategy; // ?
        IUnaryOperationStrategy? unaryOperationStrategy;
        StrategyContext strategyContext = new StrategyContext();
        Console.WriteLine("Choose the first number : ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose operation");
        var op = Console.ReadLine();

        arithmeticStrategy = op switch
        {
            "+" => new ArithmeticStrategyAdd(),
            "-" => new ArithmeticStrategySub(),
            "*" => new ArithmeticStrategyMult(),
            "/" => new ArithmeticStrategyDiv(),
            "%" => new ArithmeticStrategyPercent(),
            _ => null
        };

        unaryOperationStrategy = op switch
        {
            "^" => new StrategySquareRoot(),
            _ => null
        };

        if (arithmeticStrategy is not null)
        {
            Console.WriteLine("Choose the second number : ");
            var b = Convert.ToDouble(Console.ReadLine());
            try
            {
                strategyContext.SetStrategy(arithmeticStrategy);
                Console.WriteLine(strategyContext.ExecuteStrategy(a, b));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } else if (unaryOperationStrategy is not null)
        {
            strategyContext.SetStrategy(unaryOperationStrategy);
            Console.WriteLine(strategyContext.ExecuteStrategy(a));
        }
        else
        {
            Console.WriteLine("No such operator exists! (+, -, *, /, %, ^)");
        }

    }
}