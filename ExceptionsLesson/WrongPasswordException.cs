namespace ExceptionsLesson;

public class WrongPasswordException : UserDataException
{
    public WrongPasswordException() : base("WrongPasswordException was caught"){ }
    public WrongPasswordException(string message) : base(message){ }
}