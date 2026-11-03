namespace LibraryManagementSystem.Models
{
    internal class Person
    {
        public Person(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name cannot be empty.", nameof(firstName));
            FirstName = firstName;
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name cannot be empty.", nameof(lastName));
            LastName = lastName;
        }
        public string FirstName { get;}
        public string LastName { get;}
    }
}
