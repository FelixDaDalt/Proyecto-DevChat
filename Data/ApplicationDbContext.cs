﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto_DevChat.Models;

namespace Proyecto_DevChat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Contact>()
                .HasOne<ApplicationUser>(a => a.Users)
                .WithMany(d => d.Contacts)
                .HasForeignKey(a => a.UserId);
        }
    }
}