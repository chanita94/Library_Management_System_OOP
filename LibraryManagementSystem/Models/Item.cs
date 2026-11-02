using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Item
    {
        public Item(string title, int year)
        {
            ArgumentNullException.ThrowIfNull(title);
            Title = title;
            ArgumentOutOfRangeException.ThrowIfZero(year);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(year,2026);
            Year = year;
        }
        public string Title { get; }//read-only after creation
        public int Year { get; }//read-only after creation
        public bool IsAvailable { get; set; } = true;
    }
}
