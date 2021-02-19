using LCB.Domain.AggregateModels.BookAggregate;
using MediatR;
using System;

namespace LCB.API.Application.Queries.Books
{
    public class BookIdentityQuery : IRequest<BookIdentityQueryDTO>
    {
        public string Id { get; set; }
        public BookIdentityQuery(string id)
        {
            Id = id;
        }
    }

    public class BookIdentityQueryDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public static BookIdentityQueryDTO From(Book entity)
        {
            var dto = new BookIdentityQueryDTO();
            dto.Id = entity.Id;
            dto.Name = entity.Name;
            return dto;
        }
    }
}
