namespace _7._Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class Directory_Traversal
    {
        static void Main(string[] args)
        {
            var dirPath = Console.ReadLine();
            var fileDictionary = new Dictionary<string, List<FileInfo>>();
            var files = Directory.GetFiles(dirPath);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var extention = fileInfo.Extension;
                long fileSize = fileInfo.Length;
                if (!fileDictionary.ContainsKey(extention))
                {
                    fileDictionary.Add(extention, new List<FileInfo>());
                }
                fileDictionary[extention].Add(fileInfo);

            }
            var orderedDictionary = fileDictionary
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key)
                    .ToDictionary(x => x.Key, y => y.Value);
            var desktopPath = Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullNameOfTheFile = desktopPath + "/report.txt";
            using (var writer = new StreamWriter(fullNameOfTheFile))
            {
                foreach (var item in orderedDictionary)
                {
                    var extention = item.Key;
                    var infoofTheFile = item.Value.OrderByDescending(p => p.Length);
                    writer.WriteLine(extention);
                    foreach (var file in infoofTheFile)
                    {
                        double converted =(double) file.Length / 1024;
                        writer.WriteLine($"--{file.Name} - {converted:f3}kb");
                    }
                }
            }
        }
    }
}
