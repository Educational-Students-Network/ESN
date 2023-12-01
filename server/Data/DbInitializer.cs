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
        
        if (context.Events.Any()) return;


        var events = new List<Event>
        {
            new Event
            {
                Speakers = "Speaker1, Speaker2",
                Description = "This is event description blah blah blah.",
                Time = "22.10.2024",
                AuthorUsername = "Amogus",
                Place = "Lviv Polytechnic",
                PictureUrl = "img/png/event1.png"
            },
            new Event
            {
                Speakers = "Speaker1, Speaker2",
                Description = "This is event2 description blah blah blah.",
                Time = "22.10.2025",
                AuthorUsername = "testUser",
                Place = "Lviv Polytechnic",
                PictureUrl = "img/png/event2.png"
            }
        };

        context.Events.AddRange(events);

        // var events = new List<Event>
        // {
        //     new Event
        //     {
        //         Speakers = "Speaker1, Speaker2",
        //         Description = "This is event description blah blah blah.",
        //         Place = "Lviv Polytechnic",
        //         PictureUrl = "img/png/event1.png"
        //     },
        //     new Event
        //     {
        //         Speakers = "Speaker1, Speaker2",
        //         Description = "This is event2 description blah blah blah.",
        //         Place = "Lviv Polytechnic",
        //         PictureUrl = "img/png/event2.png"
        //     }
        // };
        //
        // context.Events.AddRange(events);

        context.SaveChanges();
    }
}