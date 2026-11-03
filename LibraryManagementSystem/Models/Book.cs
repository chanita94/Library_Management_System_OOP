namespace LibraryManagementSystem.Models
{
    internal class Book:Item
    {
        public Book(string author, int itemId, string title, int year)
            :base(itemId,title,year)
        {
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Author cannot be empty.", nameof(author));
            Author = author;
        }
        public string Author { get; }
           
    }
}
