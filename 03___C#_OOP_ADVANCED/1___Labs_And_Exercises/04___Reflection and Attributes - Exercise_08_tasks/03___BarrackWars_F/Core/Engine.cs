namespace _03BarracksFactory.Core
{
    using System;
    using _03___BarrackWars_Factory.Core;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        // i add here one additional field
        private ICommandInterpreter commandInterpreter;
        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;

            this.commandInterpreter = new CommandInterpreter(repository, unitFactory);
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = this.commandInterpreter
                                        .InterpretCommand(data, commandName)
                                        .Execute();
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
       // this code in commented because it mix 3 tasks in one and just shows the default skeleton 
       // the code further down is by default on the sceleton
       //// TODO: refactor for Problem 4
       //private string InterpredCommand(string[] data, string commandName)
       //{
       //    string result = string.Empty;
       //    switch (commandName)
       //    {
       //        case "add":
       //            result = this.AddUnitCommand(data);
       //            break;
       //        case "report":
       //            result = this.ReportCommand(data);
       //            break;
       //        case "fight":
       //            Environment.Exit(0);
       //            break;
       //        default:
       //            throw new InvalidOperationException("Invalid command!");
       //    }
       //    return result;
       //}


      //private string ReportCommand(string[] data)
      //{
      //    string output = this.repository.Statistics;
      //    return output;
      //}
      //
      //
      //private string AddUnitCommand(string[] data)
      //{
      //    string unitType = data[1];
      //    IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
      //    this.repository.AddUnit(unitToAdd);
      //    string output = unitType + " added!";
      //    return output;
      //}
    }
}
