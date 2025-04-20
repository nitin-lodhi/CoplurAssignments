using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookStore.BookManager;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore.Controllers
{
    [Route("[controller]")]
    public class BookController : Controller
    {

        IBookManager _bookManager;
        public BookController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }
        [HttpGet]
        public IActionResult GetALLBooks()
        {
            List<Book> books = _bookManager.GetALLBooks();
            if (books.Count != 0)
            {
                return Ok(books);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetBookByID(int id)
        {
            Book book = _bookManager.GetBookByID(id);
            if (book != null)
            {
                return Ok(book);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("add")]
        public IActionResult AddBook([FromBody] Book book)
        {
            bool response = _bookManager.AddBook(book);
            if (response)
            {
                return Ok("Book Added Successfully.");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updateBook)
        {
            bool response = _bookManager.UpdateBook(id, updateBook);
            if (response)
            {
                return Ok("Book Updated Successfully.");
            }
            else
            {
                return NotFound();
            }

        }


        [HttpDelete("delete/{id}")]
        public IActionResult DeleteBook(int id)
        {
            bool response = _bookManager.DeleteBook(id);
            if (response)
            {
                return Ok("Book Deleted Successfully.");
            }
            else
            {
                return NotFound();
            }
        }
    }

}