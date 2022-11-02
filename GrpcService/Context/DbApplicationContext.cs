using GrpcService.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcService.Context
{
    
        public class DbApplicationContext : DbContext
        {
            public DbApplicationContext(DbContextOptions<DbApplicationContext> options) : base(options) { }

            public DbSet<Book> Books { get; set; }
            public DbSet<BookStudentOrder> BookStudentOrders { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                Seed(builder);
                base.OnModelCreating(builder);
            }
            private void Seed(ModelBuilder builder)
            {
                builder
                    .Entity<BookStudentOrder>()
                    .HasKey(x => new { x.StudentId, x.BookId });

                builder
                    .Entity<BookStudentOrder>()
                    .HasOne(x => x.Book)
                    .WithMany(y => y.BookStudentOrders)
                    .HasForeignKey(x => x.BookId);

                builder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = 1,
                        Author = "TestAuthor1",
                        Price = 200,
                        Subject = "System integration",
                        Title = "Enterprise integration patterns",
                        IsAvailable = true,
                        ReleaseDate = DateTime.UtcNow.ToString(),
                        StudyProgrammeId = 1
                    },
                       new Book
                       {
                           Id = 2,
                           Author = "TestAuthor2",
                           Price = 300,
                           Subject = "System integration",
                           Title = "Soa",
                           IsAvailable = true,
                           ReleaseDate = DateTime.UtcNow.ToString(),
                           StudyProgrammeId = 1
                       },

                        new Book
                        {
                            Id = 3,
                            Author = "TestAuthor3",
                            Price = 200,
                            Subject = "Development of large systems",
                            Title = "Guide to CI/CD",
                            IsAvailable = true,
                            ReleaseDate = DateTime.UtcNow.ToString(),
                            StudyProgrammeId = 2
                        },
                        new Book
                        {
                            Id = 4,
                            Author = "TestAuthor4",
                            Price = 350,
                            Subject = "Development of large systems",
                            Title = "Guide to Git flow",
                            IsAvailable = true,
                            ReleaseDate = DateTime.UtcNow.ToString(),
                            StudyProgrammeId = 2
                        },
                        new Book
                        {
                            Id = 5,
                            Author = "TestAuthor5",
                            Price = 150,
                            Subject = "Test",
                            Title = "Unit testing",
                            IsAvailable = true,
                            ReleaseDate = DateTime.UtcNow.ToString(),
                            StudyProgrammeId = 3
                        },
                        new Book
                        {
                            Id = 6,
                            Author = "TestAuthor6",
                            Price = 350,
                            Subject = "Test",
                            Title = "Integration testing",
                            IsAvailable = true,
                            ReleaseDate = DateTime.UtcNow.ToString(),
                            StudyProgrammeId = 3
                        });
            }
        }
    }

