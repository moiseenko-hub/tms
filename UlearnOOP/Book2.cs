using System.Collections;
using System.Reflection;

namespace UlearnOOP;

public class Book2 : IComparable, IComparer
{ 
    public string Title { get; set; }
    public int Theme { get; set; }

    public Book2(string title, int theme)
    {
        Title = title;
        Theme = theme;
    }

    public Book2() 
    {
        
    }

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