using LCB.API.Application.Commands.Books;
using LCB.API.Application.Queries.Books;
using LCB.Domain.AggregateModels.BookAggregate;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IBookRepository _bookRepository;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var dto = await _mediator.Send(new BookIdentityQuery(id));
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BookCreateCommand command)
        {
            var id = await _mediator.Send(command);
            return await Get(id);
        }

        //public BookController(IBookRepository bookRepository)
        //{
        //    _bookRepository = bookRepository;
        //}

        //[HttpGet]
        //public ActionResult<List<Book>> Get() =>
        //   _bookRepository.Get();

        //[HttpPost]
        //public ActionResult<Book> Create(Book book)
        //{
        //    _bookRepository.Create(book);

        //    //return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);

        //    return Ok(book);
        //}
    }
}
