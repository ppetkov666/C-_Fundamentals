using System;

public class StartUp
{
    static void Main()
    {
        try
        {
            var studentInput = Console.ReadLine().Split();
            var studentFirstName = studentInput[0];
            var studentLastName = studentInput[1];
            var studentFacultyNum = studentInput[2];
            Student student = 
                new Student(studentFirstName, studentLastName, studentFacultyNum);

            var workerInput = Console.ReadLine().Split();
            var firstName = workerInput[0];
            var lastName = workerInput[1];
            var weekSalary = decimal.Parse(workerInput[2]);
            var workingHours = double.Parse(workerInput[3]);
            Worker worker = new Worker(firstName, lastName, weekSalary, workingHours);
            Console.WriteLine(student + Environment.NewLine);
            Console.WriteLine(worker);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

