using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Magazine:Item
    {
        public Magazine(string issue, string title, int year) : base(title, year)
        {
            Issue = issue;
        }

        public string Issue {  get; }
    }
}
