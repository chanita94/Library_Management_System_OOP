namespace LibraryManagementSystem.Models
{
    internal class Item
    {
        public Item(int itemId, string title, int year)
        {
            if (itemId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(itemId),"Id must be greater than 0");
            }
            ItemId = itemId;
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.", nameof(title));//null,"", " "
            Title = title;
            if (year == 0 || year>DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(year),"Year must be between 1 and the current year.");
            }
            Year = year;
        }
        public int ItemId { get;}
        public string Title { get; }
        public int Year { get; }
        public bool IsAvailable { get; private set; } = true;
    }
}
