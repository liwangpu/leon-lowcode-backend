using Base.Domain.Models;
using MediatR;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCB.API.Application.Queries.Books
{
    public class BookQuery : IRequest<BookQueryDTO>
    {
    }

    public class BookQueryDTO
    {

    }
}
