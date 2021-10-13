namespace Playground.Entities
{
    public class Person
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

        public Person(int id, string firstname, string lastname, int? age)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
    }
}
