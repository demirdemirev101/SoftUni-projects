using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext (DbContextOptions dbContextOptions): base(dbContextOptions) {}

        private const string ConnectionString = "Server=DESKTOP-LNN960H\\SQLEXPRESS;Database=StudentSystem;Integrated Security=true";

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
       */
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(x => x.Name)
                    .HasMaxLength(100)
                    .IsUnicode(true);

            modelBuilder.Entity<Student>()
                .Property(x => x.PhoneNumber)
                    .IsUnicode(false)
                    .IsRequired(false);

            modelBuilder.Entity<Course>()
                .Property(x=>x.Name)
                    .HasMaxLength(80)
                    .IsUnicode(true);

            modelBuilder.Entity<Course>()
                .Property(x => x.Description)
                    .IsUnicode(true)
                    .IsRequired(false);

            modelBuilder.Entity<Resource>()
                .Property(x => x.Name)
                    .HasMaxLength(50)
                    .IsUnicode(true);

            modelBuilder.Entity<Resource>()
                .Property(x => x.Url)
                    .IsUnicode(false);

            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Course)
                    .WithMany(c => c.Resources)
                    .HasForeignKey(r => r.CourseId);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Homework>()
                .Property(h => h.Content)
                    .IsUnicode(false);
        }
        
    }
}
