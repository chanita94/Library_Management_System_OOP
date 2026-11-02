using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Member : Person
    {
        public Member(int memberId, string firstName, string lastName):base(firstName, lastName)
        {
            MemberId = memberId;
        }
        public int MemberId { get; }
        public List <Item> BorrowedItems = new List<Item>();


    }
}
