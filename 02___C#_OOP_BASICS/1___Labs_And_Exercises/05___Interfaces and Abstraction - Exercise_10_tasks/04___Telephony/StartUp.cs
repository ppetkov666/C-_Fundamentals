using System;
class StartUp
{
    static void Main()
    {
        var phoneNums = Console.ReadLine().Split(' ');
        var webSites = Console.ReadLine().Split(' ');

        var smartphone = new Smartphone();
        foreach (var phoneNum in phoneNums)
        {
            Console.WriteLine(smartphone.Call(phoneNum));
        }
        foreach (var webSite in webSites)
        {
            Console.WriteLine(smartphone.Browse(webSite));
        }
    }
}

