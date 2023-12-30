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

        public static List<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person("John", "Doe", 11111111),
                new Person("Jane", "Doe", 22222222),
                new Person("John", "Smith", 33333333),
                };
            return people;
        }

        internal static string? GetPersonById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

