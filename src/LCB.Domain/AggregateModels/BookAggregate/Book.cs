using Base.Domain.Common;
using Base.Domain.Models;
using LCB.Domain.Events.BookEvents;

namespace LCB.Domain.AggregateModels.BookAggregate
{
    public class Book : Entity
    {
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        protected Book()
        { }

        public Book(string name)
        {
            Id = GuidGen.NewID();
            Name = name;

            AddDomainEvent(new BookCreatedEvent(Id, Name));
        }
    }
}
