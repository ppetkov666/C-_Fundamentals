using _01.Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _01.Logger.Models.Factories
{
    public class ErrorFactory
    {
        const string DATAFORMAT = "M/d/yyyy h:mm:ss tt";

        public IError CreateError(string dateTimeString, string errorLevelString, string message)
        {
            DateTime dateTime = DateTime
                .ParseExact(dateTimeString, DATAFORMAT, CultureInfo.InvariantCulture);
            
            ErrorLevel errorLevel = ParseErrorLevel(errorLevelString);
            IError error = new Error(dateTime, errorLevel, message);
            return error;
        }

        private ErrorLevel ParseErrorLevel(string errorLevel)
        {
            try
            {
                object levelObj = Enum.Parse(typeof(ErrorLevel), errorLevel);
                return (ErrorLevel)levelObj;
            }
            catch (ArgumentException ex)
            {

                throw new ArgumentException("Invalid ErrorLevel Type", ex);
            }
        }
    }
    
}
