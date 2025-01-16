namespace ExceptionsLesson;

public class UserValidator
{
    public static bool IsValid(string Login, string Password, string ConfirmPassword)
    {
        try
        {
            Validate(Login, Password, ConfirmPassword);
        }
        catch (UserDataException)
        {
            // log
            return false;
        }

        return true;
    }

    private static void Validate(string Login, string Password, string ConfirmPassword)
    {
        if (Login.Length >= 20 || Login.Contains(' '))
            throw new WrongLoginException("Wrong login exception. ");
        if (Password.Length >= 20 || Password.Contains(' ') || !ContainsNumber(Password) || !Password.Equals(ConfirmPassword))
            throw new WrongPasswordException("Wrong password exception"); 
    }

    private static bool ContainsNumber(string value)
    {
        foreach (var item in value)
        {
            if (Char.IsDigit(item))
                return true;
        }

        return false;
    }
}