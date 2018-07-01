namespace _2._Line_Numbers
{
    using System;
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {
            var path = "../Resources/text.txt";
                var counter = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    var readLine = reader.ReadLine();
                    while (readLine != null)
                    {                 
                        writer.WriteLine($"Line {counter}: {readLine}");
                        counter++;
                        readLine = reader.ReadLine();
                    }
                }            
            }
        }
    }
}
