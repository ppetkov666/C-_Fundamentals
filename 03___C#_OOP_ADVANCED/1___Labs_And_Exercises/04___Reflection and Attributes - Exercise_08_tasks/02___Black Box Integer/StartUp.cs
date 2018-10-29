namespace _02___Black_Box_Integer
{
    
    using System;
    class StartUp
    {
        static void Main()
        {
            BlackBoxIntegerTests bbit = new BlackBoxIntegerTests();
            Console.WriteLine(bbit.Run(typeof(BlackBoxInteger)));
        }
    }
}
