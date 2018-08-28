namespace _04___Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            LetTheGameBegin();
        }

        private static void LetTheGameBegin()
        {
            var stoneValues = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            //Stones is gene
            Stones<int> stones = new Stones<int>(stoneValues);

            Console.WriteLine(string.Join(", ", stones));
        }
    }
}
