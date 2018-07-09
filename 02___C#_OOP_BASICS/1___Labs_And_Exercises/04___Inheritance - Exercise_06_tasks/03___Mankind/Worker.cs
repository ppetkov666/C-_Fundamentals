using System;
using System.Text;

public class Worker : Human
{
    private const int WorkDaysPerweek = 5;
    private decimal weeklySalary;
    private double workingHours;

    public Worker(string firstName, string lastName, decimal weeklySalary,double workingHours)
        :base(firstName,lastName)
    {
        this.WeeklySalary = weeklySalary;
        this.WorkingHours = workingHours;
    }
     
    public decimal WeeklySalary
    {
        get { return this.weeklySalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weeklySalary = value;
        }
    }
    public double WorkingHours
    {
        get { return this.workingHours; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workingHours = value;
        }
    }
    public decimal SalaryPerHour => WeeklySalary / (decimal)(workingHours * WorkDaysPerweek);
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString())
            .AppendLine($"Week Salary: {this.weeklySalary:f2}")
            .AppendLine($"Hours per day: {this.workingHours:f2}")
            .AppendLine($"Salary per hour: {this.SalaryPerHour:f2}");


        var result = builder.ToString().TrimEnd();
        return result;
    }
}

