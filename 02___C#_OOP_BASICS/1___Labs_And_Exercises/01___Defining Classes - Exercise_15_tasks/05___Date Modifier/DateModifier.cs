using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public class DateModifier
{
    public static int GetDaysDifference(string firstDate,string secondDate)
    {
        var parsedFirstDate = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var parsedSecondtDate = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var difference = Math.Abs((parsedFirstDate - parsedSecondtDate).Days);
        return difference;
    }
}

