using Microsoft.EntityFrameworkCore;
using schoolAPI.Models;
using System.Reflection.Emit;

namespace schoolAPI.Contexts

{
    public class DbApplicationContext : DbContext
    {
        public DbApplicationContext(DbContextOptions<DbApplicationContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudyProgramme> StudyProgrammes { get; set; }
        public DbSet<StudentStudyProgramme> StudentStudyProgrammes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Seed(builder);
            base.OnModelCreating(builder);
        }

        private void Seed(ModelBuilder builder)
        {
            

            builder
                .Entity<StudentStudyProgramme>()
                .HasKey(x => new { x.StudentId, x.StudyProgrammeId });

            builder
                .Entity<StudentStudyProgramme>()
                .HasOne(x => x.Student)
                .WithMany(y => y.StudentStudyProgramme)
                .HasForeignKey(x => x.StudentId);

            builder
                .Entity<StudentStudyProgramme>()
                .HasOne(x => x.StudyProgramme)
                .WithMany(y => y.StudentStudyProgramme)
                .HasForeignKey(x => x.StudyProgrammeId);


            builder.Entity<Student>().HasData(
                new Student { Name = "Phillip", Email = "Phillip@gmail.com", Id = 1 },
                new Student { Name = "Lukas", Email = "Lukas@gmail.com", Id = 2 },
                new Student { Name = "Christoffer", Email = "Christoffer@gmail.com", Id = 3 }
                );


            builder.Entity<StudyProgramme>().HasData(
                new StudyProgramme { Name = "System Integration", Id = 1 },
                new StudyProgramme { Name = "Development of Large Systems", Id = 2 },
                new StudyProgramme { Name = "Test", Id = 3 }
            );


            builder.Entity<StudentStudyProgramme>().HasData(
                new StudentStudyProgramme { StudentId = 1, StudyProgrammeId = 1});

        }
    }
}
