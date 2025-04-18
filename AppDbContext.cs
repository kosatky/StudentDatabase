using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase

{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=MasterPassword;Database=StudentDB");
        }
    }
}