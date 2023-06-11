﻿using BookingCarProject.Areas.Identity.Data;
using BookingCarProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingCarProject.Data;

public class BookingDbContext : IdentityDbContext<ApplicationUser>
{
    public BookingDbContext(DbContextOptions<BookingDbContext> options)
        : base(options)
    {
    }
    public DbSet<Cartype> Cartype { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
