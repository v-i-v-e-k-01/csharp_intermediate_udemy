using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationBetweenClasses
{
    ////Inheritance
    //public class Text : PresentationObject
    //{
    //    public int FontSize { get; set; }
    //    public string FontName
    //    {
    //        get; set;
    //    }

    //    public void AddHyperLink(string url)
    //    {
    //        Console.WriteLine("We added a link to "+url);
    //    }
    //}


    ////////////////////////////////////////////

    //Composition
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;

        }

        public void Migrate()
        {
            _logger.Log("We are migrating");
        }
    }

    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installer installed something");
        }
    }
    ////////////////////////////////////////////

    public class Program
    {
        static void Main(string[] args)
        {
            ////Inheritance
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();

            ////////////////////////////////////////////


            //Composition

            var dbMigrator = new DbMigrator(new Logger());
            
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }


}
