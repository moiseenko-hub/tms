namespace ExceptionsLesson;

public class WrongLoginException : UserDataException
{
    public WrongLoginException() : base("WrongLoginException was caught"){ }
    public WrongLoginException(string message) : base(message){ }
}