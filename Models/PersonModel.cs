namespace Last.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, int number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Number { get; set; }



        internal static string? GetPersonById(int id)
        {
            return id switch
            {
                1 => "John",
                2 => "Mary",
                3 => "Bob",
                _ => null
            };
        }
    }
}

