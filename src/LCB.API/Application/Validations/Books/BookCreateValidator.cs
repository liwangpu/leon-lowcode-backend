using FluentValidation;
using LCB.API.Application.Commands.Books;

namespace LCB.API.Application.Validations.Books
{
    public class BookCreateValidator : AbstractValidator<BookCreateCommand>
    {
        public BookCreateValidator()
        {
            RuleFor(cmd => cmd.Name).Must(x => !string.IsNullOrWhiteSpace(x));
        }
    }
}
