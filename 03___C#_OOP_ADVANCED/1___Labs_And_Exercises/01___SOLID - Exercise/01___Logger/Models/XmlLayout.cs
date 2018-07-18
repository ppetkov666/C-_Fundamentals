using _01.Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _01.Logger.Models
{
    public class XmlLayout : ILayout
    {
        const string DATAFORMAT = "M/d/yyyy h:mm:ss tt";
        private string Format = "<log>" + Environment.NewLine +
                                "\t<date>{0}</date>" + Environment.NewLine +
                                "\t<level>{1}</level>" + Environment.NewLine +
                                "\t<message>{2}</message>" + Environment.NewLine +
                                "</log>";                                            
        public string FormatError(IError error)
        {
            string dateAsString = error
                .DateTime
                .ToString(DATAFORMAT, CultureInfo.InvariantCulture);
            string formattedError = string
                .Format(Format, dateAsString, error.Level, error.Message);
            return formattedError;
        }
    }
}
