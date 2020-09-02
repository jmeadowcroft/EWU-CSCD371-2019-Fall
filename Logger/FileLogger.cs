using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace Logger
{
    public class FileLogger : BaseLogger
    {

        public FileLogger(string path)
        {
            NumOfLoggedMesssages = 0;
            if (path == null)
                throw new ArgumentNullException("Please set a path");
            FilePath = @path;
            if (Path.GetDirectoryName(FilePath) == "")
                throw new ArgumentException("Not a valid path");
            else
            {
                using (SW = File.CreateText(FilePath));
            }
        }
        public override void Log(LogLevel logLevel, string message)
        {
            NumOfLoggedMesssages++;

            var callingMethod = new StackTrace().GetFrame(1).GetMethod();
            var callingClass = callingMethod.ReflectedType.Name;
            string logLevelString = logLevel.ToString();
            string current = DateTime.Now.ToString("g");
            string line = $"{logLevelString}|{message}|From {callingClass}|at {current}";
            using (SW = new StreamWriter(FilePath, true))
            {
                SW.WriteLine(line);
            }
            LastLog = line;

        }

        public int NumOfLoggedMesssages{ get; set;}
        public string FilePath { get; private set; }
        public StreamWriter SW { get; private set; }
        public string LastLog { get; set; }

        
        
    }

}