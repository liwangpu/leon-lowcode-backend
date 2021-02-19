using System;
using System.Collections.Generic;
using System.Text;

namespace LCB.Domain.AggregateModels.BookAggregate
{
    public interface IBookRepository
    {
        List<Book> Get();
        Book Create(Book book);
    }
}
