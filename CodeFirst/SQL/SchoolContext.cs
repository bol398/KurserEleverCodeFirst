using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQL
{
    public class SchoolContext : DbContext
    {
        private const string connectionString = "Server=localhost;Database=EFCore;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }

    }
}
