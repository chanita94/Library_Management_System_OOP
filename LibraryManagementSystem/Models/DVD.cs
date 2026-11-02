using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class DVD:Item
    {
        public DVD(string studio, string title, int year) : base(title, year)
        {
            Studio = studio;
        }
        public string Studio { get; }

    }
}
