using System.Collections;

namespace UlearnOOP;

public class Book : IComparable, IComparer
{ 
    public string Title; 
    public int Theme;

    public int CompareTo(object obj)
    {
        var other = (Book)obj;
        if (Theme.CompareTo(other.Theme) == 0)
            return Title.CompareTo(other.Title);
        return Theme.CompareTo(other.Theme);
    }

    public int Compare(object? x, object? y)
    {
        throw new NotImplementedException();
    }
}