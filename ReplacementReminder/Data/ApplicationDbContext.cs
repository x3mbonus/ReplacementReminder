using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ReplacementReminder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ReplacementItem> ReplacementItems { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<ReplacementHistoryEntry> ReplacementHistory { get; set; }

    }
}
