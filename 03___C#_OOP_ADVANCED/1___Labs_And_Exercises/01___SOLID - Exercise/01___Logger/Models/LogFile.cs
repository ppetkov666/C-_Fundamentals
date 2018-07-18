using _01.Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _01.Logger.Models
{
    class LogFile : ILogFile
    {
        const string DefaultPath = "./data/";

        public LogFile(string fileName)
        {
            this.Path = DefaultPath + fileName;
            InitializeFIle();
            this.Size = 0;
        }

        private void InitializeFIle()
        {
            Directory.CreateDirectory(DefaultPath);
            File.AppendAllText(this.Path, "");
        }

        public string Path { get; }
        public int Size { get; private set; }

        public void WriteToFile(string errorLog)
        {
            File.AppendAllText(this.Path, errorLog + Environment.NewLine);
            int addedSize = 0;
            for (int i = 0; i < errorLog.Length; i++)
            {
                addedSize += errorLog[i];
            }
            this.Size += addedSize;
        }
    }
}
