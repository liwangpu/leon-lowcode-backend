using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LCB.API.Application.Queries.Books
{
    public class BookQueryHandler : IRequestHandler<BookQuery, BookQueryDTO>
    {
        public async Task<BookQueryDTO> Handle(BookQuery request, CancellationToken cancellationToken)
        {

            return new BookQueryDTO();
        }
    }
}
