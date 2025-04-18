using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.BookManager
{
    public class BookManager : IBookManager
    {
         public static List<Book> books = new List<Book>();

         public List<Book> GetALLBooks(){
             return books;
         }
         public Book GetBookByID(int id){
             return books.FirstOrDefault(book => book.id == id);
         }

         public bool AddBook(Book book){
             if(book != null){
                if(book.id != null && book.title != null && book.author != null && book.publishYear != null){
                    books.Add(book);
                    return true;
                }else{
                    Console.WriteLine("Empty Fields.");
                    return false;
                }
             }else{
                Console.WriteLine("Empty Fields.");
                return false;
             }
         }

         public bool UpdateBook(int id,Book updatedBook){
              int idx = books.FindIndex(book => book.id == id);
              if( idx >= 0){
                 books[idx] = updatedBook;
                 return true;
              }else{
                Console.WriteLine("Can't update book,bcz Book not found by this id.");
                return false;
              }
         }
         public bool DeleteBook(int id){
             int idx = books.FindIndex(book => book.id == id);
             if(idx >= 0){
                books.RemoveAll(book => book.id == id);
                return true;
             }else{
               Console.WriteLine("Can't delete book, bcz Book not found by this id.");
               return false;
             }
         } 
    }
}