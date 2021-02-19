using MediatR;

namespace LCB.Domain.Events.BookEvents
{
    public class BookCreatedEvent : INotification
    {
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public BookCreatedEvent(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
