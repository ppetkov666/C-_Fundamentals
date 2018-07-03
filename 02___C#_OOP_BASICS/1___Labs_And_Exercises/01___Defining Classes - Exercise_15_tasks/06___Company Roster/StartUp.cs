using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    static void Main()
    {
        List<Department> departments = new List<Department>();
        var numOFEmployees = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOFEmployees; i++)
        {
           var splittedInput = Console.ReadLine().Split();
            string departmentName = splittedInput[3];
            if (!departments.Any(d=>d.Name == departmentName))
            {
                Department dep = new Department(departmentName);
                departments.Add(dep);
            }
            var department = departments.FirstOrDefault(d => d.Name == departmentName);
            Employee emps = EmployeeInfo(splittedInput);
            department.AddEmployee(emps);
        }
        var HighestAvSalary = departments.OrderByDescending(d => d.AverageSalary).First();
        Console.WriteLine($"Highest Average Salary: {HighestAvSalary.Name}");
        foreach (var emp in HighestAvSalary.Employees.OrderByDescending(p=>p.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
        }
    }
    static Employee EmployeeInfo(string[] splittedInput)
    {
        
        string name = splittedInput[0];
        decimal salary = decimal.Parse(splittedInput[1]);
        string position = splittedInput[2];
        string email = "n/a";
        int age = -1;
        if (splittedInput.Length == 6)
        {
            email = splittedInput[4];
            age = int.Parse(splittedInput[5]);
        }
        else if (splittedInput.Length == 5)
        {
            bool isAge = int.TryParse(splittedInput[4], out age);
            if (!isAge)
            {
                email = splittedInput[4];
                age = -1;
            }
        }
        Employee employee = new Employee(name, position, salary, age, email);
        return employee;
    }
}

