using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LDT1721050111.Models
{
    public partial class Bt26 : DbContext
    {
        public Bt26()
            : base("name=Bt2610DBContext")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecture>()
                .Property(e => e.Faculty)
                .IsUnicode(true);
            modelBuilder.Entity<Lecture>()
                .Property(e => e.Department)
                .IsUnicode(true);
        }
    }
}
