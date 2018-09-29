namespace _09___Linked_List_Traversal
{
    using System;
    using System.Text;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var linkedList = new LinkedList<int>();
            ExecCommand(linkedList);
            PrintFinalResult(linkedList);
        }

        private static void PrintFinalResult(LinkedList<int> linkedList)
        {
            Console.WriteLine(linkedList.Count);
            Console.WriteLine(string.Join(" ", linkedList));
        }

        private static void ExecCommand(LinkedList<int> linkedList)
        {
            var numOfCmd = int.Parse(Console.ReadLine());

            while (numOfCmd > 0)
            {
                var cmd = Console.ReadLine().Split();
                var number = int.Parse(cmd[1]);

                switch (cmd[0])
                {
                    case "Add":
                        linkedList.Add(number);
                        break;
                    case "Remove":
                        linkedList.Remove(number);
                        break;
                    default:
                        break;
                }

                numOfCmd--;
            }
        }
    }
}
