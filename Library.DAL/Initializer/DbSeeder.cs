using Library.DAL.Constants;
using Library.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Initializer
{
    public static class DbSeeder
    {
        public static async Task Seed(AppDbContext context)
        {
            try
            {
                await context.Database.MigrateAsync();

                if (!context.Roles.Any())
                {
                    var adminRole = new RoleEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = Roles.Admin,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    };

                    var userRole = new RoleEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = Roles.User,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    };

                    await context.Roles.AddAsync(adminRole);
                    await context.Roles.AddAsync(userRole);
                    await context.SaveChangesAsync();

                    if (!context.Users.Any(u => u.UserName == "admin"))
                    {
                        var user = new UserEntity
                        {
                            Id = Guid.NewGuid(),
                            UserName = "admin",
                            Email = "admin@gmail.com",
                            Password = "qwerty",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            RoleId = adminRole.Id
                        };

                        await context.Users.AddAsync(user);
                        await context.SaveChangesAsync();

                        var author = new AuthorEntity
                        {
                            Id = Guid.NewGuid(),
                            FirstName = "Author",
                            LastName = "Test",
                            BirthYear = 1900,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        };

                        await context.Authors.AddAsync(author);

                        var testBook = new BookEntity
                        {
                            Id = Guid.NewGuid(),
                            Title = "Test book",
                            AuthorId = author.Id,
                            PageCount = 100,
                            Category = "Testings",
                            Language = "UA",
                            Publisher = "Library",
                            Year = 2024,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            Users = new List<UserEntity> { user }
                        };

                        await context.Books.AddAsync(testBook);

                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
