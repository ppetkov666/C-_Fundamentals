namespace _8._Full_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    class Full_Directory_Traversal
    {
        static void Main(string[] args)
        {
            var dirPath = Console.ReadLine();                  
            var directories = FullListDirectories(dirPath);
            var fileDictionary = new Dictionary<string, List<FileInfo>>();
            foreach (var dir in directories)
            {
                GetFilewithExtentionsFromDir(dir, fileDictionary);
            }
             fileDictionary = fileDictionary
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key)
                    .ToDictionary(x => x.Key, y => y.Value);
            ReportFromDirectory(fileDictionary);
        }
        private static List<string> FullListDirectories (string dirPath)
        {
            var fullListDirectories = new List<string>();
            var directories = Directory.GetDirectories(dirPath);
            foreach (var item in directories)
            {
                fullListDirectories.AddRange(FullListDirectories(item));
            }
            fullListDirectories.Add(dirPath);
            return fullListDirectories;
        }

        private static void GetFilewithExtentionsFromDir(string dir, Dictionary<string, List<FileInfo>> fileDictionary)
        {
            string[] fullpath = Directory.GetFiles(dir);
            foreach (var file in fullpath)
            {
                var extention = file.Substring(file.LastIndexOf('.'));
                if (!fileDictionary.ContainsKey(extention))
                {
                    fileDictionary.Add(extention, new List<FileInfo>());
                }
                var fileInfo = new FileInfo(file);
                fileDictionary[extention].Add(fileInfo);

            }    
        }
        private static void ReportFromDirectory(Dictionary<string, List<FileInfo>> fileDictionary)
        {
            
            var desktopPath = Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop);
            
            using (var writer = new StreamWriter($"{desktopPath}\\report.txt"))
            {
                foreach (var item in fileDictionary)
                {
                    var extention = item.Key;
                    List<FileInfo> infoofTheFile = item.Value;
                    writer.WriteLine(extention);
                    foreach (var file in infoofTheFile.OrderBy(p=>p.Length))
                    {
                        double converted = (double)file.Length / 1024;
                        writer.WriteLine($"--{file.Name} - {converted:f3}kb");
                    }
                }
            }
        }
    }
}
