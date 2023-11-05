﻿using Microsoft.AspNetCore.Identity;
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole { Name = "Member", NormalizedName = "MEMBER" },
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Mentor", NormalizedName = "MENTOR" }
            );
    }
}