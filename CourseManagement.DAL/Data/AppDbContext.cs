using CourseManagement.DAL.Models;
using CourseManagement.DAL.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }
        //public DbSet<Models.Course> Courses => Set<Models.Course>();
        //public DbSet<Session> Sessions => Set<Session>();
        //public DbSet<AppUser> Users => Set<AppUser>();
        //public DbSet<Grade> Grades => Set<Grade>();

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Course>()
                .HasIndex(c => c.Name).IsUnique();


        }
    }
    }
