using Library.BLL.Services.Classes;
using Library.BLL.Services.Interfaces;
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

            using (var context = new AppDbContext())
            {
                IUserRepository userRepository = new UserRepository(context);
                IUserService userService = new UserService(userRepository);

                DbSeeder.Seed(context);

                Application.Run(new MainForm(userService));

                context.Dispose();
            }
        }
    }
}