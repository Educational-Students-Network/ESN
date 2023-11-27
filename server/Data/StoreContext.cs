using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using server.Entities;

namespace server.Data;

public class StoreContext : IdentityDbContext<User>
{
    public StoreContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Event> Events { get; set; }


    public DbSet<User> Users { get; set; }

    public DbSet<Comment> Comment { get; set; }
    
    public DbSet<Like> Like { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole { Name = "Member", NormalizedName = "MEMBER" },
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Mentor", NormalizedName = "MENTOR" }
            );
        builder.Entity<User>()
            .HasMany(u => u.Comments)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<User>()
            .HasMany(u => u.Likes)
            .WithOne(l => l.User)
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Event>()
            .HasMany(e => e.Comments)
            .WithOne(c => c.Event)
            .HasForeignKey(c => c.EventId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Event>()
            .HasMany(e => e.Likes)
            .WithOne(l => l.Event)
            .HasForeignKey(l => l.EventId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}