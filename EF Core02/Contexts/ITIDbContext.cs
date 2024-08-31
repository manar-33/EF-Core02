using EF_Core02.Configurations;
using EF_Core02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            
            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
            modelBuilder.Entity<Student>().HasOne(s => s.Department)
                                          .WithMany(d => d.Students)
                                          .HasForeignKey(s => s.DepartmentId);
            // modelBuilder.Entity<Stud_Course>().HasKey(SC => new { SC.Student_Id, SC.Course_Id });

            // modelBuilder.Entity<Course>().HasMany(C => C.Students)
            //                              .WithOne(C => C.Courses)
            //                              .HasForeignKey(C => C.CourseId);
            modelBuilder.Entity<Topic>().HasMany(T => T.Courses)
                                        .WithOne(C => C.Topic)
                                        .HasForeignKey(C => C.TopicId);


            modelBuilder.Entity<Instructor>().HasOne(I => I.Department)
                                             .WithOne(d => d.Instructor)
                                             .HasForeignKey<Instructor>(I => I.DepartmentId);


            modelBuilder.Entity<Department>().HasMany(d => d.Instructors)
                                             .WithOne(i => i.ContainingDepartment);
                                             
                                            



            modelBuilder.Entity<Course>(C =>
            {
                C.HasKey(C => C.Id);
                C.Property(C => C.Description)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            });

            modelBuilder.Entity<Instructor>(Inst =>
            {
                Inst.HasKey(Inst => Inst.Id);
                Inst.Property(Inst => Inst.Address)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            }
            );
            modelBuilder.Entity<Stud_Course>(SC =>
            {
                SC.HasKey(SC => new { SC.Course_Id, SC.Student_Id })
                .HasName("PK_Stud_Course");
            });
            modelBuilder.Entity<Course_Inst>(CI =>
            {
                CI.HasKey(CI => new { CI.Course_Id, CI.Inst_Id })
                .HasName("PK_Course_Inst");
            });


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIDb; Trusted_Connection = True;Encrypt=True;TrustServerCertificate=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
