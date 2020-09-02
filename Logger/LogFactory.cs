namespace Logger
{
    public class LogFactory
    {
        public LogFactory()
        {

        }
        
        public BaseLogger CreateLogger(string loggerName)
        {
            if (FilePath != null)
            {
                FileLogger fileLogger = new FileLogger(FilePath);
                if (loggerName != null)
                    fileLogger.Name = loggerName;
                else
                    fileLogger.Name = "";

                return fileLogger;
            }
            else
            {
                return null;
            }
        }

        public void ConfigureFileLogger(string path)
        {
            FilePath = path;
        }

        private string FilePath { get; set; }


    }
}
