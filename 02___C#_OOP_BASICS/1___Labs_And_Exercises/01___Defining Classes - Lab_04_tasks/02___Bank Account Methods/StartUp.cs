
using System;
class StartUp
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Id = 1;
        account.Deposit(15);
        account.Withdraw(10);
        Console.WriteLine(account);
    }
}

