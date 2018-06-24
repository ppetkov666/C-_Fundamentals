namespace _07.BalancedParenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {   
        static void Main()
        {
            var openParenthesis = new char[3];
            openParenthesis[0] = '[';
            openParenthesis[1] = '(';
            openParenthesis[2] = '{';
            var closeParenthesis = new char[3];
            closeParenthesis[0] = ']';
            closeParenthesis[1] = ')';
            closeParenthesis[2] = '}';
            var input = Console.ReadLine().ToCharArray();
            var parenthesisHystory = new Stack<char>();
            var areBalanced = true;
            foreach (var symbol in input)
            {
                if (openParenthesis.Contains(symbol))
                {
                    parenthesisHystory.Push(symbol);
                    continue;
                }
                if (closeParenthesis.Contains(symbol))
                {
                    if (parenthesisHystory.Count == 0)
                    {
                        areBalanced = false;
                        break;
                    }
                    var openedWith = parenthesisHystory.Pop();
                    if (!CheckBalance(openedWith, symbol))
                    {
                        areBalanced = false;
                        break;
                    }
                }
            }
            Console.WriteLine(areBalanced ? "YES" : "NO");
        }
        public static bool CheckBalance(char openedWith, char closedWith)
        {
            switch (openedWith)
            {
                case '(':
                    return (closedWith == ')') ? true : false;
                case '[':
                    return (closedWith == ']') ? true : false;
                case '{':
                    return (closedWith == '}') ? true : false;
                default:
                    return false;
            }
        }
    }
}
