using Base.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCB.Domain.AggregateModels.BookAggregate
{
    public interface IBookRepository : IRepository
    {
        Task<List<Book>> Query();
        Task<Book> Create(Book book);
        Task<Book> Get(string id);
    }
}
