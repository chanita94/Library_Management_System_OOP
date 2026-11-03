namespace LibraryManagementSystem.Models
{
    internal class Item
    {
        public Item(string title, int year)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.", nameof(title));//null,"", " "
            Title = title;
            if (year == 0 || year>DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(year),"Year must be between 1 and the current year.");
            }
            Year = year;
        }
        public string Title { get; }//read-only after creation
        public int Year { get; }//read-only after creation
        public bool IsAvailable { get; private set; } = true;
    }
}
