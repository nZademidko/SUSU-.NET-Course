namespace AbstractVirtualMachine.Logging
{
    public static class FileLogger
    {
        public static void LogToFile(string message)
        {
            System.IO.File.AppendAllText(c_LogFilePath, message + "\n");
        }

        private const string c_LogFilePath = @"C:\Users\Nikita\RiderProjects\Course3\Course3\data\logger\log.txt";
    }
}
