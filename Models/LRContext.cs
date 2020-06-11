using System;
using Microsoft.EntityFrameworkCore;

namespace LoginAndRegistration.Models
{
    public class LRContext : DbContext
    {
        public LRContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
