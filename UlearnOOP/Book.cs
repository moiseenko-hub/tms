using System.Collections;

namespace UlearnOOP;

public class Book(string title, int theme) : IComparable, IComparer
{ 
    public string Title = title; 
    public int Theme = theme;

    public Book() //  A constructor declared in 'class' with parameter list must have 'this' constructor initializer
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