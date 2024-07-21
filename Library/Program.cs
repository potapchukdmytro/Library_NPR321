using Library.DAL;
using Library.DAL.Initializer;
using Library.DAL.Repositories.Classes;
using Library.DAL.Repositories.Interfaces;

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
            IUserRepository userRepository = new UserRepository(context);

            DbSeeder.Seed(context);

            Application.Run(new MainForm(userRepository));
        }
    }
}