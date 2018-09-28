
namespace _08___Pet_Clinic.Controllers
{
    using System;
    using System.Linq;
    using System.Text;

    public class Engine
    {
        private ClinicsManager manager;
        private StringBuilder activityReport;

        public Engine()
        {
            this.manager = new ClinicsManager();
            this.activityReport = new StringBuilder();
        }

        public void Run()
        {
            var numOfCommands = int.Parse(Console.ReadLine());

            while (numOfCommands > 0)
            {
                var cmd = Console.ReadLine().Split();
                string clinicName;
                string operationResult;

                try
                {
                    switch (cmd[0])
                    {
                        case "Create":
                            this.ProcessCreation(cmd.Skip(1).ToArray());
                            break;
                        case "Add":
                            var petName = cmd[1];
                            clinicName = cmd[2];
                            operationResult = this.manager.AddPetToAClinic(petName, clinicName).ToString();
                            this.activityReport.AppendLine(operationResult);
                            break;
                        case "Release":
                            clinicName = cmd[1];
                            operationResult = this.manager.ReleaseAnumalFromClinic(clinicName).ToString();
                            this.activityReport.AppendLine(operationResult);
                            break;
                        case "HasEmptyRooms":
                            clinicName = cmd[1];
                            this.activityReport.AppendLine(this.manager.HasEmptyRooms(clinicName).ToString());
                            break;
                        case "Print":
                            this.ProcessPrinting(cmd.Skip(1).ToArray());
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    this.activityReport.AppendLine(ae.Message);
                }

                numOfCommands--;
            }

            Console.WriteLine(this.activityReport.ToString().Trim());
        }

        private void ProcessPrinting(string[] command)
        {
            var clinicName = command[0];

            if (command.Length > 1)
            {
                var roomNumber = int.Parse(command[1]);
                this.activityReport.AppendLine(this.manager.PrintRoom(clinicName, roomNumber));
            }
            else
            {
                this.activityReport.Append(this.manager.PrintClinic(clinicName));
            }
        }

        private void ProcessCreation(string[] cmdArgs)
        {
            var name = cmdArgs[1];

            if (cmdArgs[0] == "Pet")
            {
                var age = int.Parse(cmdArgs[2]);
                var kind = cmdArgs[3];
                this.manager.CreatePet(name, age, kind);
            }
            else if (cmdArgs[0] == "Clinic")
            {
                var rooms = int.Parse(cmdArgs[2]);

                try
                {
                    this.manager.CreateClinic(name, rooms);
                }
                catch (ArgumentException ae)
                {
                    this.activityReport.AppendLine(ae.Message);
                }
            }
        }
    }
}
