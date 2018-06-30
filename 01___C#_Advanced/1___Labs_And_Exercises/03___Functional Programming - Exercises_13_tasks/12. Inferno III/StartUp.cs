namespace _12._Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {

            var gems = Console.ReadLine().Split().Select(int.Parse).ToList();
            var filters = new Dictionary<string, Func<List<int>, List<int>>>();
            string input;
            while ((input = Console.ReadLine()) != "Forge")
            {
                ParseCommand(input, filters);
            }
            List<int> filtered = Getfiltered(gems, filters);
            gems = gems.Where(gem => !filtered.Contains(gem)).ToList();
            Console.WriteLine(string.Join(" ",gems));
        }

        private static List<int> Getfiltered(List<int> gems, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            var filtered = new List<int>();
            foreach (var pair in filters)
            {
                var filter = pair.Value;
                filtered.AddRange(filter(gems));
                
            }
            return filtered;
        }

        private static void ParseCommand(string input, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            var splittedInput = input.Split(';').ToArray();
            var command = splittedInput[0];
            var filterType = splittedInput[1];
            var parameter = int.Parse(splittedInput[2]);
            var keyDictionary = $"{filterType} {parameter}";

            if (command == "Exclude")
            {
                filters[keyDictionary] = CreateFunction(filterType, parameter);
            }
            else if (command == "Reverse")
            {
                filters.Remove(keyDictionary);
            }

        }

        private static Func<List<int>, List<int>> CreateFunction(string filterType, int parameter)
        {
            switch (filterType)
            {
                case "Sum Left":
                    return gems => gems.Where(gem =>
                         {
                             int index = gems.IndexOf(gem);
                             int leftgem = index > 0 ? gems[index - 1] : 0;
                             return gem + leftgem == parameter;
                         }).ToList();
                case "Sum Right":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int rightgem = index < gems.Count - 1 ? gems[index + 1] : 0;
                        return gem + rightgem == parameter;
                    }).ToList();
                case "Sum Left Right":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int leftgem = index > 0 ? gems[index - 1] : 0;
                        int rightgem = index < gems.Count - 1 ? gems[index + 1] : 0;
                        return gem + rightgem + leftgem== parameter;
                    }).ToList();
                default:
                    throw new NotFiniteNumberException();
                    
            }
        }
    }
}
