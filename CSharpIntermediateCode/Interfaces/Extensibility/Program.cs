using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    //Interfaces and Extensibility

    public class DbMirgator
    {
        private readonly ILogger _logger;
        public DbMirgator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            //Details of migrating database
            _logger.LogInfo("Migration stopped at {0}" + DateTime.Now);
        }
    }

    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);

        }
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR: ");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO:");
        }

        public void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
                streamWriter.Dispose();
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMirgator(new FileLogger("C:\\Users\\E272830\\Desktop\\C# Intermediate"));
            dbMigrator.Migrate();
        }
    }
}
