namespace ConsoleApp1_tms;

public enum Operation
{
    Sum,
    Subtract,
    Multiply
}
public class OperationManager
{
    private int _first;
    private int _second;
    public OperationManager(int first, int second)
    {
        _first = first;
        _second = second;
    }
    private int Sum()
    {
        return _first + _second;
    }
    private int Subtract()
    {
        return _first - _second;
    }
    private int Multiply()
    {
        return _first * _second;
    }
    public int Execute(Operation operation)
    {
        switch (operation)
        {
            case Operation.Sum:
                return Sum();
            case Operation.Subtract:
                return Subtract();
            case Operation.Multiply:
                return Multiply();
            default:
                return -1; //just to simulate
        }
    }
}

public class ExecutionManager
{
    private Dictionary<Operation, Func<int, int, int>> FuncExecute { get; } = new();

    public void RegisterDelegate(Operation operation, Func<int,int,int> func)
    {
        FuncExecute.Add(operation,func);
    }
    public int PrepareExecution(int a, int b, Operation operation)
    {
        if (!FuncExecute.ContainsKey(operation)) 
            throw new ArgumentException($"The operation {operation.ToString()} does not exist");
        return FuncExecute[operation](a, b);
    }
}
