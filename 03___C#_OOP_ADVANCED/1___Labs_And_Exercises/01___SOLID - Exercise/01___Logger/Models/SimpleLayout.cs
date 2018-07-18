using _01.Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _01.Logger.Models
{
    public class SimpleLayout : ILayout
    {
        //error.dateTime, error.level, error.message
        const string FORMAT = "{0} - {1} - {2}";
        const string DATAFORMAT = "M/d/yyyy h:mm:ss tt";
        public string FormatError(IError error)
        {
            string dateAsString = error
                .DateTime
                .ToString(DATAFORMAT,CultureInfo.InvariantCulture);
            string formattedError = string
                .Format(FORMAT, dateAsString, error.Level, error.Message);
            return formattedError;
        }
    }
}
