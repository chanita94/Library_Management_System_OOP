namespace LibraryManagementSystem.Models
{
    internal class Member : Person
    {
        public Member(int memberId, string firstName, string lastName):base(firstName, lastName)
        {
            if (memberId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(memberId));
            }
            MemberId = memberId;
        }
        public int MemberId { get; }
        private List <Item> BorrowedItems = new List<Item>();


    }
}
