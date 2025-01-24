using System.Drawing;
using System.Text.RegularExpressions;

namespace LinqUlearn;

public class Linq
{
    public static int[] ParseNumbers(IEnumerable<string> lines)
    {
        return lines
            .Where(x => int.TryParse(x, out int number))
            .Select(x => int.Parse(x))
            .ToArray();
    }
    
    public static List<Point> ParsePoints(IEnumerable<string> lines)
    {
        return lines
            .Select(x => {
                var points = x.Split();
                return new Point(int.Parse(points[0]), int.Parse(points[1]));
            })
            .ToList();
    }
    
    public static string? GetLongest(IEnumerable<string> words)
    {
        return words
            .Select(x => Tuple.Create(-x.Length, x))
            .Min(x => x)
            ?.Item2;
    }
    
    public static (string, int Length)[] GetMostFrequentWords(string text, int count)
    {
        return Regex.Split(text, @"\W+")
            .Where(word => word != "")
            .GroupBy(x => x)
            .Select(x=> (x.Key, x.Count()))
            .OrderByDescending(x=>x.Item2)
            .ThenBy(x => x.Item1)
            .Take(count)
            .ToArray();
    }
    
    public static string[] GetSortedWords(params string[] textLines)
    {
        return textLines
            .SelectMany(x => x.Split(new char[] { ' ', ';', '.', ',', '\'' }, StringSplitOptions.RemoveEmptyEntries))
            .Select(y => y.ToLower())
            .Distinct()
            .OrderBy(x => x)
            .ToArray();
    }
    
    public static List<string>  GetSortedWords(string text)
    {
        return text
            .Split(new char[] { ' ', ';', '.', ',', '\'' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.ToLower())
            .Distinct()
            .OrderBy(x => x.Length)
            .ThenBy(x => x)
            .ToList();
    }
    private static string[] GetAllStudents(Classroom[] classes)
    {
        return classes.
            SelectMany(x => x.Students)
            .ToArray();
    }
    


}