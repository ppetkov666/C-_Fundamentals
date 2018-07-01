namespace _1._Odd_Lines
{
    using System;
    using System.IO;
    class StartUp
    {
        static void Main()
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
                        if (counter % 2 == 0)
                        {
                            writer.WriteLine($"{readLine}");
                        }                       
                        counter++;
                        readLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
