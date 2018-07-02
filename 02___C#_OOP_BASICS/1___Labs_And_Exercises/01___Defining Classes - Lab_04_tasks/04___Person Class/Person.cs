﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    string name;
    int age;
    List<BankAccount> accounts;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        accounts = new List<BankAccount>();
    }
    public Person(string name, int age,List<BankAccount> accounts)
    {
        this.accounts = accounts;
    }
    public decimal GetBalance()
    {
        return accounts.Sum(p => p.Balance);
    }


}


