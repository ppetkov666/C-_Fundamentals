namespace _4._Copy_Binary_File
{
    using System;
    using System.IO;

    class StartUp
    {
        static void Main(string[] args)
        {

            var inputFile = "../Resources/copyMe.png";
            using (FileStream reader = new FileStream(inputFile, FileMode.Open))
            {
                using (FileStream writer = new FileStream("output.txt", FileMode.Create))
                {
                    var buffer = new byte[4096];

                    while (true)
                    {
                        var readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }       
        }
    }
}
