using LCB.Domain.Events.BookEvents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LCB.API.Application.DomainEventHandlers.Books
{
    public class CheckBookInfo : INotificationHandler<BookCreatedEvent>
    {
        public async Task Handle(BookCreatedEvent notification, CancellationToken cancellationToken)
        {

        }
    }
}
