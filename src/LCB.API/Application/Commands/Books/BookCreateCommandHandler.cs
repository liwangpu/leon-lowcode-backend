using LCB.Domain.AggregateModels.BookAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LCB.API.Application.Commands.Books
{
    public class BookCreateCommandHandler : IRequestHandler<BookCreateCommand, string>
    {
        private readonly IBookRepository _bookRepository;
        public BookCreateCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<string> Handle(BookCreateCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Name);
            await _bookRepository.Create(book);
            return book.Id;
        }
    }
}
