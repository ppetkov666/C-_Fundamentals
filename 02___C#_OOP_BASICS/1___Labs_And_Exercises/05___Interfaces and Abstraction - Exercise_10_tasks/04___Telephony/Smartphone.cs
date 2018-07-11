using System.Linq;
public class Smartphone : ICallable, IBrowsable
{
    public string Browse(string webSite)
    {
        if (webSite.Any(ch => char.IsDigit(ch)))
        {
            return "Invalid URL!";
        }
        return $"Browsing: {webSite}!";
    }

    public string Call(string phoneNumber)
    {
        for (int i = 0; i < phoneNumber.Length; i++)
        {
            if (!char.IsDigit(phoneNumber[i]))
            {
                return "Invalid number!";
            }
        }
        return $"Calling... {phoneNumber}";
    }
}