using Base.Infrastructure;
using LCB.Domain.AggregateModels.BookAggregate;
using LCB.Infrastructure.Datastores;
using MediatR;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCB.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IMongoCollection<Book> _books;
        private readonly IMediator _mediator;
        public BookRepository(IBookStoreSettings settings, IMediator mediator)
        {
            _mediator = mediator;
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Book>(settings.BooksCollectionName);
        }

        public async Task<Book> Create(Book book)
        {
            _books.InsertOne(book);
            await _mediator.DispatchDomainEventsAsync(book);
            return book;
        }

        public async Task<List<Book>> Query()
        {
            return _books.Find(book => true).ToList();
        }

        public async Task<Book> Get(string id)
        {
            return _books.Find<Book>(book => book.Id == id).FirstOrDefault();
        }

        //public List<Book> Get() =>
        //_books.Find(book => true).ToList();

        //public Book Get(string id) =>
        //    _books.Find<Book>(book => book.Id == id).FirstOrDefault();

        //public Book Create(Book book)
        //{
        //    _books.InsertOne(book);
        //    //_mediator.DispatchDomainEventsAsync(this);
        //    return book;
        //}

        //public void Update(string id, Book bookIn) =>
        //    _books.ReplaceOne(book => book.Id == id, bookIn);

        //public void Remove(Book bookIn) =>
        //    _books.DeleteOne(book => book.Id == bookIn.Id);

        //public void Remove(string id) =>
        //    _books.DeleteOne(book => book.Id == id);
    }
}
