using System;
using System.Text;
public class Human
{
    private const int FirstNameMinLenght = 4;
    private const int LastNameMinLenght = 3;
    private const string CapitalLetterError = "Expected upper case letter! Argument: {0}";
    private const string LenghtError = "Expected length at least {0} symbols! Argument: {1}";

    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.Lastname = lastName;
    }
    public string FirstName
    {
        get { return firstName; }
        set
        {
            ValidateName(value, nameof(firstName), FirstNameMinLenght);
            firstName = value;
        }
    }
    public string Lastname
    {
        get { return this.lastName; }
        set
        {
            ValidateName(value, nameof(lastName), LastNameMinLenght);
            lastName = value;
        }
    }
    private static void ValidateName(string value ,string name,  int lenght)
    {
        if (char.IsLower(value[0]))
        {
            throw new ArgumentException(string.Format(CapitalLetterError,name));
        }
        if (value.Length < lenght )
        {
            throw new ArgumentException(string.Format(LenghtError,lenght,name));
        }
    }
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.firstName}")
            .AppendLine($"Last Name: {this.lastName}");
        var result = builder.ToString().TrimEnd();
        return result;
    }
}

