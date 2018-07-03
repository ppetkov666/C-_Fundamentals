using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { age = value; }
    }


}

