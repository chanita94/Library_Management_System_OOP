namespace LibraryManagementSystem.Models
{
    internal class Book:Item
    {
        public Book(string author, string title, int year)
            :base(title,year)
        {
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Author cannot be empty.", nameof(author));
            Author = author;
        }
        public string Author { get; }
           
    }
}
