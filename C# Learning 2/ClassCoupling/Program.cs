using System.Threading;

namespace ClassCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance();
            //Composition();
            
        }

        public static void Inheritance()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        public static void Composition()
        {
            var dbMigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
