using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    public static void Main()
    {
        Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
        Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


        string command;
        while ((command = Console.ReadLine()) != "Output")
        {
            string department, patient;
            Doctor doctor;
            InitializeDoctorsAndDepartments(doctors, departments, command, out department, out patient, out doctor);
            AddPatientsToDifferentDepartmensAndRooms(doctors, departments, department, patient, doctor);
        }
        while ((command = Console.ReadLine()) != "End")
        {
            string[] args = command.Split();
            PrintTheOutputAccordingToArgs(doctors, departments, args);
        }
    }
    private static void AddPatientsToDifferentDepartmensAndRooms(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string department, string patient, Doctor doctor)
    {
        bool hasAvailableBeds = departments[department].SelectMany(x => x).Count() < 60;
        if (hasAvailableBeds)
        {
            int room = 0;
            doctors[doctor.FullName].Add(patient);
            for (int roomNum = 0; roomNum < departments[department].Count; roomNum++)
            {
                if (departments[department][roomNum].Count < 3)
                {
                    room = roomNum;
                    break;
                }
            }
            departments[department][room].Add(patient);
        }
    }

    private static void InitializeDoctorsAndDepartments(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string command, out string department, out string patient, out Doctor doctor)
    {
        string[] splittedInput = command.Split();
        department = splittedInput[0];
        patient = splittedInput[3];
        doctor = new Doctor(splittedInput[1], splittedInput[2]);
        if (!doctors.ContainsKey(doctor.FullName))
        {
            doctors[doctor.FullName] = new List<string>();
        }
        if (!departments.ContainsKey(department))
        {
            departments[department] = new List<List<string>>();
            for (int rooms = 0; rooms < 20; rooms++)
            {
                departments[department].Add(new List<string>());
            }
        }
    }

    private static void PrintTheOutputAccordingToArgs(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string[] args)
    {
        if (args.Length == 1)
        {
            Console.WriteLine(string.Join(Environment.NewLine, departments[args[0]]
                .Where(x => x.Count > 0)
                .SelectMany(x => x)));
        }
        else if (args.Length == 2 && int.TryParse(args[1], out int room))
        {
            Console.WriteLine(string.Join(Environment.NewLine, departments[args[0]][room - 1].OrderBy(x => x)));
        }
        else
        {
            Console.WriteLine(string.Join(Environment.NewLine, doctors[args[0] +" " +  args[1]].OrderBy(x => x)));
        }
    }

}
