using BookAPI.Models;
using Grpc.Net.Client;
using GrpcService;

namespace BookAPI.Service
{
    public interface IBookService
    {
        public Task<List<Book>> GetAllBooks();
        public Task<List<Book>> GetAllBooksfiltered(string? subject, double? budget);

        public Task<bool> BuyBook(BuyBookDto buyBookDto);

        public Task<bool> ReturnBook(int bookId);
    }
    public class BookService : IBookService
    {
        public async Task<bool> BuyBook(BuyBookDto buyBookDto)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7011");
            var client = new Greeter.GreeterClient(channel);

            return client.BuyBook(
                new BuyBookRequest
                {
                    BookId = buyBookDto.BookId,
                    StudentId = buyBookDto.StudentId
                }).IsSucces;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7011");
            var client = new Greeter.GreeterClient(channel);
            var books = client.GetAllBooks(new Empty());

            var listOfBooks = books.BookReply.Select(b =>
            new Book
            {
                Subject = b.Subject,
                Title = b.Title,
                Author = b.Author,
                Price = b.Price,
                ReleaseDate = b.ReleaseDate,
                IsAvailable = b.IsAvaible,
                StudyProgrammeId = b.StudyProgrammeId
            }).ToList();

            return listOfBooks;
        }

        public async Task<List<Book>> GetAllBooksfiltered(string? subject, double? budget)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7011");
            var client = new Greeter.GreeterClient(channel);
            var books = client.GetAllBooksFiltered(new BooksRequest
            {
                Budget = !budget.HasValue ? 0 : (double)budget,
                Subject = !String.IsNullOrEmpty(subject) ? subject : "",
            });

            var listOfBooks = books.BookReply.Select(b =>
            new Book
            {
                Subject = b.Subject,
                Title = b.Title,
                Author = b.Author,
                Price = b.Price,
                ReleaseDate = b.ReleaseDate,
                IsAvailable = b.IsAvaible,
                StudyProgrammeId = b.StudyProgrammeId
            }).ToList();

            return listOfBooks;
        }

        public async Task<bool> ReturnBook(int bookId)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7011");
            var client = new Greeter.GreeterClient(channel);

            return client.ReturnBook(
             new ReturnBookRequest
             {
                 BookId = bookId
             }).IsSucces;
        }
    }
}
