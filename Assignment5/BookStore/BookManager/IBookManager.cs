using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;


namespace BookStore.BookManager
{
    public interface IBookManager
    {
         public List<Book> GetALLBooks();
         public Book GetBookByID(int id);

         public bool AddBook(Book book);

         public bool UpdateBook(int id,Book updatedBook);
         public bool DeleteBook(int id);

    }
}