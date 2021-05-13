using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SundayMobilityApplication.Models
{
    public partial class StudentDatabaseContext : DbContext
    {
        public StudentDatabaseContext()
        {
        }

        public StudentDatabaseContext(DbContextOptions<StudentDatabaseContext> options)
            : base(options)
        {
        }

        //db
        public virtual DbSet<Student> student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
