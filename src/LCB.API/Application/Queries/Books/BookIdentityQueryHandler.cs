using LCB.Domain.AggregateModels.BookAggregate;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LCB.API.Application.Queries.Books
{
    public class BookIdentityQueryHandler : IRequestHandler<BookIdentityQuery, BookIdentityQueryDTO>
    {
        private readonly IBookRepository _bookRepository;
        public BookIdentityQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookIdentityQueryDTO> Handle(BookIdentityQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.Get(request.Id);
            return BookIdentityQueryDTO.From(book);
        }
    }
}
