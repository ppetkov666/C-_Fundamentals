using System;
using System.Collections.Generic;
using System.Text;
public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary; 

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
    }
    public void IncreaseSalary(decimal percentage)
    {
        if (this.age > 30 )
        {
            this.salary += this.salary * percentage / 100;
        }
        else
        {
            this.salary += this.salary * percentage / 200;
        }
    }
}

