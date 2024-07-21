using Library.DAL.Constants;
using Library.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Initializer
{
    public static class DbSeeder
    {
        public static async void Seed(AppDbContext context)
        {
            try
            {
                await context.Database.MigrateAsync();

                if (!context.Roles.Any())
                {
                    var admin = new RoleEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = Roles.Admin,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    };

                    var user = new RoleEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = Roles.User,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    };

                    await context.Roles.AddAsync(admin);
                    await context.Roles.AddAsync(user);
                    await context.SaveChangesAsync();

                    if (!context.Users.Any(u => u.UserName == "admin"))
                    {
                        var entity = new UserEntity
                        {
                            Id = Guid.NewGuid(),
                            UserName = "admin",
                            Email = "admin@gmail.com",
                            Password = "qwerty",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            RoleId = admin.Id
                        };

                        await context.Users.AddAsync(entity);
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
