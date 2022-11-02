using GrpcService.Context;
using GrpcService.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcService.Repository
{

    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooks();
        Task<List<Book>> GetAllBooksFiltered(string? subject, double? budget);
        Task<bool> BuyBook(BuyBookDto buyBookDto);
        Task<bool> ReturnBook(int bookId);
    }

    public class BookRepository : IBookRepository
    {
        private readonly DbApplicationContext _context;

        public BookRepository(DbApplicationContext dbApplicationContext)
        {
            _context = dbApplicationContext;
        }
        public async Task<bool> BuyBook(BuyBookDto buyBookDto)
        {
            var book = await _context.Books.FindAsync(buyBookDto.BookId);

            if (!book.IsAvailable)
            {
                return false;
            }


            var newOrder = new BookStudentOrder
            {
                BookId = buyBookDto.BookId,
                StudentId = buyBookDto.StudentId
            };

            book.IsAvailable = false;

            await _context.BookStudentOrders.AddAsync(newOrder);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<List<Book>> GetAllBooksFiltered(string? subject, double? budget)
        {
            List<Book> books = null;

            if (String.IsNullOrEmpty(subject) && budget == 0)
            {
                books = await _context.Books.ToListAsync();
            }

            if (String.IsNullOrEmpty(subject) && budget != 0)
            {
                books = await _context.Books
                    .Where(_ => _.Price < budget)
                    .ToListAsync();
            }

            if (!String.IsNullOrEmpty(subject) && budget == 0)
            {
                books = await _context.Books
                   .Where(_ => _.Subject == subject)
                   .ToListAsync();
            }

            else
            {
                books = await _context.Books
                    .Where(_ => _.Price < budget && _.Subject == subject)
                    .ToListAsync();
            }

            return books;
        }

        public async Task<bool> ReturnBook(int bookId)
        {
            try
            {
                var book = await _context.Books.FindAsync(bookId);

                book.IsAvailable = true;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

