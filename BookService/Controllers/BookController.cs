using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookLibrary;


namespace BookService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private static readonly List<Book> books = new List<Book>()
        {
            new Book("Harry Potter","J.K.Rowling",435,"1234567891235"),
            new Book("Wiedzmin","A.Sapkowski",234,"5432167891235"),
            new Book("Koszmar","D.Pieniek",435,"9876543213215"),
            new Book("Faramon","T.Okon",332,"4567891234567"),
            new Book("Akustyka","O.Kasztan",444,"2345678912345")

        };



        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public Book Get(string id)
        {
            return books.Find(i => i.Lsbn13 == id);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            books.Add(value);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Book value)
        {
            Book book = Get(id);
            if(book != null)
            {
                book.Title = value.Title;
                book.Author = value.Author;
                book.PageNum = value.PageNum;
                book.Lsbn13 = value.Lsbn13;
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Book book = Get(id);
            books.Remove(book);

        }
    }
}
