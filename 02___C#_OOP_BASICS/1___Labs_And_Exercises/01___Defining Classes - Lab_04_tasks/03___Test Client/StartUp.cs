using System;
using System.Collections.Generic;
class StartUp
{
    static void Main()
    {
        Dictionary<int,BankAccount> accounts = new Dictionary<int, BankAccount>();
        string inputCommand;
        while ((inputCommand = Console.ReadLine()) != "End")
        {
            string[] splittedinput = inputCommand.Split();
            int accountID = int.Parse(splittedinput[1]);
            switch (splittedinput[0])
            {
                case "Create":
                    if (accounts.ContainsKey(accountID))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        var account = new BankAccount();
                        account.Id = accountID;
                        accounts.Add(accountID, account);
                    }                    
                    break;
                case "Deposit":
                    if (ValidateAccountExisting(accountID,accounts))
                    {

                        accounts[accountID].Deposit(int.Parse(splittedinput[2]));
                    }
                    break;
                case "Withdraw":
                    if (ValidateAccountExisting(accountID, accounts))
                    {

                        accounts[accountID].Withdraw(int.Parse(splittedinput[2]));
                    }
                    break;
                case "Print":
                    if (ValidateAccountExisting(accountID, accounts))
                    {

                        Console.WriteLine(accounts[accountID]);
                    }
                    break;
                default:
                    break;
            }
        }
    }
    static bool ValidateAccountExisting(int id , Dictionary<int,BankAccount> account)
    {
        if (account.ContainsKey(id))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Account does not exist");
            return false;
        }      
    }
}

