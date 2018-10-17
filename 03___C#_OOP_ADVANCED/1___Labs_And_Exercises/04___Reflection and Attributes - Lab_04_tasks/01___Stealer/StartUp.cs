namespace _01___Stealer
{
    using System;
    public class Program
    {
        static void Main()
        {
            var spy = new Spy();
            var result = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }
}
