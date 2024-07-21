using Library.DAL;
using Library.DAL.Initializer;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            AppDbContext context = new AppDbContext();

            DbSeeder.Seed(context);

            Application.Run(new MainForm());
        }
    }
}