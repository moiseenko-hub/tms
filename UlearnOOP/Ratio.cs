namespace UlearnOOP;

public class Ratio
{
    public readonly int Numerator; //числитель
    public readonly int Denominator; //знаменатель
    public readonly double Value; //значение дроби Numerator / Denominator
    
    public Ratio(int num, int den)
    {
        if (den <= 0)
            throw new ArgumentException();
        Denominator = den;
        Numerator = num;
        Value = Numerator / Denominator;
    }
}
