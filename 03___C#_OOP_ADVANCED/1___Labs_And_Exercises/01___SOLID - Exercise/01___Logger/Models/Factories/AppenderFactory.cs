using _01.Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.Models.Factories
{
    public class AppenderFactory
    {
        const string DefaultFileName = "logFile{0}.txt";
        private LayoutFactory layoutFactory;
        private int fileNumber;
        public AppenderFactory(LayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;
            this.fileNumber = 0;
        }
        public IAppender CreateAppender(string appenderType, string layoutType, string errorLevel)
        {
            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            ErrorLevel errorType = this.ParseErrorLevel(errorLevel);

            IAppender appender = null;

            switch (appenderType)
            {
                case "ConsoleAppender":
                    appender = new ConsoleAppender(layout,errorType);
                    break;
                case "FileAppender":
                    ILogFile logFile = new LogFile(string.Format(DefaultFileName, fileNumber));
                    appender = new FileAppender(layout, errorType,logFile);
                    break;
                default:
                    throw new ArgumentException("Invalid Appender Type!");
            }
            return appender;
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

                throw new ArgumentException("Invalid ErrorLevel Type",ex);
            }
        }
    }
}
