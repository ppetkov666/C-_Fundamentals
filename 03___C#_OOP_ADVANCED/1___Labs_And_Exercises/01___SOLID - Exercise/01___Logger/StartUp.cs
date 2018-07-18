namespace _01.Logger
{
    using _01.Logger.Models;
    using _01.Logger.Models.Contracts;
    using _01.Logger.Models.Factories;
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            ILogger logger = InitializeLogger();
            ErrorFactory errorFactory = new ErrorFactory();
            Engine engine = new Engine(logger, errorFactory);
            engine.Run();
        }

        static ILogger InitializeLogger()
        {
            ICollection<IAppender> appenders = new List<IAppender>();
            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);

            int appendersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < appendersCount; i++)
            {
                string[] args = Console.ReadLine().Split();
                var appenderType = args[0];
                var layoutType = args[1];
                var errorLevel = "INFO";
                if (args.Length == 3)
                {
                    errorLevel = args[2];
                }
                IAppender appender = appenderFactory
                    .CreateAppender(appenderType, layoutType, errorLevel);
                appenders.Add(appender);

            }
            ILogger logger = new Logger(appenders);
            return logger;
        }
    }
}
