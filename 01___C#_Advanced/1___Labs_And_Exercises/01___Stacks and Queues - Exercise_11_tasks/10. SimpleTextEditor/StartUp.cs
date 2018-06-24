namespace _10.SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stakeForStorageText = new Stack<string>();
            var text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var command = int.Parse(input[0]);
                switch (command)
                {
                    case 1:
                        if (input.Length > 1)
                        {
                            var texttoadd = input[1];
                            stakeForStorageText.Push(text.ToString());
                            text.Append(texttoadd);
                        }
                        break;
                    case 2:
                        if (input.Length > 1)
                        {
                            var countelementsforErease = int.Parse(input[1]);
                            if (countelementsforErease > 0 
                                && countelementsforErease <= text.Length)
                            {
                                stakeForStorageText.Push(text.ToString());
                                text.Remove(text.Length - countelementsforErease,
                                    countelementsforErease);
                            }
                        }
                        break;
                    case 3:
                        if (input.Length > 1)
                        {
                            var positionForPrinting = int.Parse(input[1]);
                            if (positionForPrinting >=0 &&
                                positionForPrinting<=text.Length)
                            {
                                Console.WriteLine(text[positionForPrinting - 1]);
                            }                            
                        }
                        break;
                    case 4:
                        text.Clear();
                        text.Append(stakeForStorageText.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
