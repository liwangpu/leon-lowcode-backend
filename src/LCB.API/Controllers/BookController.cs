using LCB.Domain.AggregateModels.BookAggregate;
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

        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get() =>
           _bookRepository.Get();

        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            _bookRepository.Create(book);

            //return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);

            return Ok(book);
        }
    }
}
