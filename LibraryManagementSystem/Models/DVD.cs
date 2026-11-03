namespace LibraryManagementSystem.Models
{
    internal class DVD:Item
    {
        public DVD(string studio, string title, int year) 
            : base(title, year)
        {
            if (string.IsNullOrWhiteSpace(studio))
                throw new ArgumentException("Studio cannot be empty.", nameof(studio));
            Studio = studio;
        }
        public string Studio { get; }

    }
}
