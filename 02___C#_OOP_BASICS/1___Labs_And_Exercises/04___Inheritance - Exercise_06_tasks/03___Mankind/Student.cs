using System;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    private const string FacultyNumberPattern = @"^[A-Za-z\d]{5,10}$";
    private string facultyNumber;
    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName,lastName)
    {
        this.FacultyNumber = facultyNumber;
    }       
    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (!Regex.IsMatch(value,FacultyNumberPattern))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString())
            .AppendLine($"Faculty number: {this.facultyNumber}");
        var result = builder.ToString().TrimEnd();
        return result;
    }
}

