using Base.Domain.Models;
using MediatR;
using System.Linq;
using System.Threading.Tasks;

namespace Base.Infrastructure
{
    public static class MediatorExtension
    {
        public static async Task DispatchDomainEventsAsync(this IMediator mediator, Entity entity)
        {
            if (entity.DomainEvents.Count == 0) { return; }

            var tasks = entity.DomainEvents.Select(async e =>
            {
                await mediator.Publish(e);
            });
            await Task.WhenAll(tasks);
        }
    }
}
