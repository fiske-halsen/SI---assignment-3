using Grpc.Core;
using GrpcService;
using GrpcService.Models;
using GrpcService.Repository;
using System;

namespace GrpcService.Services
{
    public class BookService : Greeter.GreeterBase
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async override Task<BookReplyList> GetAllBooks(Empty empty, ServerCallContext context)
        {
            var books = await _bookRepository.GetAllBooks();

            var tempBooksList = books.Select(b =>
            new BookReply
            {
                Subject = b.Subject,
                Title = b.Title,
                Author = b.Author,
                Price = b.Price,
                ReleaseDate = b.ReleaseDate,
                IsAvaible = b.IsAvailable,
                StudyProgrammeId = b.StudyProgrammeId
            }).ToList();

            var bookReplyList = new BookReplyList();
            bookReplyList.BookReply.AddRange(tempBooksList);

            return bookReplyList;
        }

        public async override Task<BookReplyList> GetAllBooksFiltered(BooksRequest booksRequest, ServerCallContext context)
        {
            var books = await _bookRepository.GetAllBooksFiltered(booksRequest.Subject, booksRequest.Budget);
            var tempBooksList = books.Select(b =>
              new BookReply
              {
                  Subject = b.Subject,
                  Title = b.Title,
                  Author = b.Author,
                  Price = b.Price,
                  ReleaseDate = b.ReleaseDate,
                  IsAvaible = b.IsAvailable,
                  StudyProgrammeId = b.StudyProgrammeId
              }).ToList();

            var bookReplyList = new BookReplyList();
            bookReplyList.BookReply.AddRange(tempBooksList);

            return bookReplyList;
        }

        public async override Task<BookResponse> ReturnBook(ReturnBookRequest returnBookRequest, ServerCallContext context)
        {
            var isSucces = await _bookRepository.ReturnBook(returnBookRequest.BookId);
            return new BookResponse { IsSucces = isSucces };
        }

        public async override Task<BookResponse> BuyBook(BuyBookRequest buyBookRequest, ServerCallContext context)
        {
            var isSucces = await _bookRepository.BuyBook(new BuyBookDto
            {
                BookId = buyBookRequest.BookId,
                StudentId = buyBookRequest.StudentId
            });

            return new BookResponse { IsSucces = isSucces };
        }
    }
}