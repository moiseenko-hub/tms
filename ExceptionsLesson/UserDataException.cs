namespace ExceptionsLesson;

public class UserDataException : Exception
{
    public UserDataException() : base("UserDataException was caught") { }
    public UserDataException(string message) : base(message){ }
}