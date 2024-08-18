using AutoMapper;
using Library.BLL.AutomapperProfiles;
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
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var context = new AppDbContext())
            {
                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfiles(new List<Profile>
                    {
                        new UserAutomapperProfile(),
                        new BookAutomapperProfile()
                    });
                });

                IMapper mapper = new Mapper(configuration);

                IUserRepository userRepository = new UserRepository(context);
                IBookRepository bookRepository = new BookRepository(context);

                IUserService userService = new UserService(userRepository, mapper, bookRepository, context);
                IAuthService authService = new AuthService(userRepository, mapper);
                IBookService bookService = new BookService(bookRepository, mapper);

                await DbSeeder.Seed(context);

                Application.Run(new MainForm(userService, authService,bookService));

                context.Dispose();
            }
        }
    }
}