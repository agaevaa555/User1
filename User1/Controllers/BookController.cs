using User1.Model;
using User1.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("getAll")]
        public IEnumerable<Book> Get()
        {
            var books = _bookRepository.GetAll();
            return books;
        }
    }
}

