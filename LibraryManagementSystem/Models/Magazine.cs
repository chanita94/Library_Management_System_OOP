namespace LibraryManagementSystem.Models
{
    internal class Magazine:Item
    {
        public Magazine(string issue, int itemId, string title, int year) 
            : base(itemId,title, year)
        {
            if (string.IsNullOrWhiteSpace(issue))
                throw new ArgumentException("Issue cannot be empty.", nameof(issue));
            Issue = issue;
        }

        public string Issue {  get; }
    }
}
