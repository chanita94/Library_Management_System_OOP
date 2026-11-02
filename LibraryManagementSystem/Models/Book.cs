using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Book:Item
    {
        public Book(string author, string title, int year):base(title,year)
        {
            ArgumentNullException.ThrowIfNull(author);
            Author = author;
        }
        public string Author { get; }
           
    }
}
