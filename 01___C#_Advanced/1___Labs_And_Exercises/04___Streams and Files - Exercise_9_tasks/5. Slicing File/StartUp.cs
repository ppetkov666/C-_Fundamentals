namespace _5._Slicing_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class StartUp
    {
        private const int bufferSize = 4096;
        static void Main(string[]args)
        {
            var sourceFile = "../Resources/sliceMe.mp4";
            var destination = "";
            var parts = 5;
            Slice(sourceFile, destination, parts);
            var files = new List<string>
            {
                "Part-0.mp4",
                "Part-1.mp4",
                "Part-2.mp4",
                "Part-3.mp4",
                "Part-4.mp4",
            };
            
            Assemble(files, destination);
        }
        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                var extension = sourceFile.Substring(sourceFile.LastIndexOf('.'));
                var pieceSize = (long)Math.Ceiling((double)reader.Length / parts);
                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;
                    if (destinationDirectory == string.Empty)
                    {
                        destinationDirectory = "./";
                    }
                    
                    var currentPart = destinationDirectory + $"Part-{i}{extension}";
                    using (FileStream writer = new FileStream(currentPart, FileMode.Create))
                    {
                        var buffer = new byte[bufferSize];
                        
                        while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                        {
                            writer.Write(buffer, 0, bufferSize);
                            currentPieceSize += bufferSize;
                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        static void Assemble(List<string> files, string destinationDirectory)
        {
            var extension = files[0].Substring(files[0].LastIndexOf('.'));
            if (destinationDirectory == string.Empty)
            {
                destinationDirectory = "./";
            }
            if (!destinationDirectory.EndsWith("/"))
            {
                destinationDirectory +="/";
            }
            var assembledFile = $"{destinationDirectory}Assembled{extension}";
            var writer = new FileStream(assembledFile, FileMode.Create);
            foreach (var item in files)
            {
                var buffer = new byte[bufferSize];
                using (FileStream reader = new FileStream(item,FileMode.Open))
                {
                    while (reader.Read(buffer,0,buffer.Length) == bufferSize)
                    {
                        writer.Write(buffer, 0, bufferSize);
                    }
                }
            }
        }
    }
}