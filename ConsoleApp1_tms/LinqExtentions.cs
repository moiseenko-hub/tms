namespace ConsoleApp1_tms;

public class LinqExtentions
{
    public static IEnumerable<T> Take<T>(IEnumerable<T> source, int count)
    {
        foreach (var item in source)
        {
            if (count > 0)
                yield return item;
            count--;
        }
    }
}