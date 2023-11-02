using Microsoft.AspNetCore.Identity;
using server.Entities;

namespace server.Data;

public static class DbInitializer
{
    public static async Task Initialize(StoreContext context, UserManager<User> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new User
            {
                UserName = "aboba",
                Email = "user1@example.com",
                PhoneNumber = "1234567890",
            };
            
            await userManager.CreateAsync(user, "Password1.");
            await userManager.AddToRoleAsync(user, "Member");

            var admin = new User
            {
                UserName = "admin",
                Email = "user2@example.com",
                PhoneNumber = "9876543210"
                
            };
            
            await userManager.CreateAsync(admin, "Password2.");
            
            await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            
        }
    }
}