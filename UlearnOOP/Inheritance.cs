using System.Reflection;

namespace UlearnOOP;

public class Inheritance
{
    public static void Print(Array array)
    {
        if (array == null)
        {
            Console.WriteLine("null");
            return;
        }
        for (int i = 0; i < array.Length; i++)
            Console.Write("{0} ", array.GetValue(i));
        Console.WriteLine();
    }

    public static Array? Combine(params Array[]? array)
    {
        if (array == null || array.Length == 0)
            return null;
        var elementType = array.GetValue(0)?.GetType().GetElementType();
        var elementsLength = 0;
        foreach (var item in array)
        {
            if (item.GetType().GetElementType() != elementType)
            {
                return null;
            }

            elementsLength += item.Length;
        }
        var resultArray = Array.CreateInstance(elementType, elementsLength);
        var resultArrayCounter = 0;
        foreach (var item in array)
        {
            AddArray(resultArray,item, resultArrayCounter);
            resultArrayCounter += item.Length;
        }
        return resultArray;
    }

    private static void AddArray(Array resultArray, Array expandingArray, int resultArrayCounter)
    {
        for (var i = 0; i < expandingArray.Length; i++, resultArrayCounter++)
        {
            resultArray.SetValue(expandingArray.GetValue(i),resultArrayCounter);
        }
    }

    public static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
    {
        if (a.CompareTo(b) > 0 && a.CompareTo(c) < 0 || a.CompareTo(c) > 0 && a.CompareTo(b) < 0)
            return a;
        if (b.CompareTo(a) > 0 && b.CompareTo(c) < 0 || b.CompareTo(c) > 0 && b.CompareTo(a) < 0)
            return b;
        if (c.CompareTo(a) > 0 && c.CompareTo(b) < 0 || c.CompareTo(b) > 0 && c.CompareTo(a) < 0)
            return c;
        return null;
    }

    public static object Min(Array comparables)
    {
        var min = (IComparable)comparables.GetValue(0);
        foreach (var item in comparables)
        {
            if (min.CompareTo(item) > 0)
                min = (IComparable)item;
        }

        return min;
    }
}