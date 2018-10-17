namespace _03___Mission_Private_Impossible
{
    using System;
    class Program
    {
        static void Main()
        {
            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(result);
        }
    }
}
