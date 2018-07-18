namespace _01.Logger
{
    using _01.Logger.Models;
    using _01.Logger.Models.Contracts;
    using _01.Logger.Models.Factories;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;
        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }
        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var errorArgs = input.Split("|");
                var errorLevel = errorArgs[0];
                var dateTime = errorArgs[1];
                var message = errorArgs[2];
                IError error = errorFactory.CreateError(dateTime,errorLevel,message);
                logger.Log(error);

            }

            Console.WriteLine("Logger info");
            foreach (IAppender appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
