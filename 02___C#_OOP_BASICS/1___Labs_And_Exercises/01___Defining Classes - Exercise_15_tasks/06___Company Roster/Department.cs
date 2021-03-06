﻿using System.Collections.Generic;
using System.Linq;
public class Department
{
    private List<Employee> employees;
    string name;
    public Department(string name)
    {
        this.Employees = new List<Employee>();
        this.Name = name;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public List<Employee> Employees 
    {
        get { return employees; }
        private set { this.employees = value; }
    }
    public decimal AverageSalary
    {
        get
        {
            return this.Employees.Select(p => p.Salary).Average();
        }
    }

    public void AddEmployee(Employee employee)
    {
        this.Employees.Add(employee);
    }
}