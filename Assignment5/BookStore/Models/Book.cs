using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
         public int id {get; set;} 
         public string title {get; set;}
         public string author {get; set;}
         
         public int publishYear {get; set;}
    }
}