namespace _04.BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StartUp
    {
        static void Main()
        {
            var queue = new Queue<int>();
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numstoAdd = input[0];
            var numstoRemove = input[1];
            var searchedelement = input[2];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numstoAdd; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < numstoRemove; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }           
            else if (queue.Contains(searchedelement))
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
