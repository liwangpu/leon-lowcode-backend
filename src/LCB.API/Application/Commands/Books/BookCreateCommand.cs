using MediatR;

namespace LCB.API.Application.Commands.Books
{
    public class BookCreateCommand : IRequest<string>
    {
        public string Name { get; set; }
    }
}
