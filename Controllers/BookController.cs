using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Library.Commands;
using Library.Handlers;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [Route("api/book/create")]
        [HttpPost]

        public GenericCommandResult Create(
                [FromBody] CreateBookCommand command,
                [FromServices] BookHandler handler
            )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("api/book/{bookId}/update")]
        [HttpPost]
        public GenericCommandResult Update(
             [FromBody] UpdateBookCommand command,
             [FromServices] BookHandler handler
         )
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}



