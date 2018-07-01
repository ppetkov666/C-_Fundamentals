namespace _3._Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {         
            var wordCounterDictionary = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader("../Resources/words.txt"))
            {
                var readWords = reader.ReadToEnd().ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                using (StreamReader secondreader = new StreamReader("../Resources/text.txt"))
                {
                    var readerText = secondreader.ReadToEnd().ToLower()
                        .Split(new char[] { '.', '-', ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    foreach (var word in readWords)
                    {
                        wordCounterDictionary[word] = 0;
                    }
                    foreach (var word in readerText)
                    {
                        if (wordCounterDictionary.ContainsKey(word))
                            wordCounterDictionary[word] += 1;
                    }
                    var orderedDictionaryWords = wordCounterDictionary.
                        OrderByDescending(p => p.Value)
                        .ToDictionary(p => p.Key, p => p.Value);

                    using (StreamWriter writer = new StreamWriter("result.txt"))
                    {
                        foreach (var word in orderedDictionaryWords)
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}
