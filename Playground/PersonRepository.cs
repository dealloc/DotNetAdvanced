using Playground.Entities;
using System.Data.SqlClient;

namespace Playground
{
    public class PersonRepository
    {
        private readonly SqlConnection _connection;

        public PersonRepository()
        {
            _connection = new SqlConnection("Data Source=(local);Initial Catalog=Playground;Integrated Security=True");

            _connection.Open();
        }

        public List<Person> GetAllPeople()
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id], [firstname], [lastname], [age] FROM [Persons]";

            var people = new List<Person>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var person = MapPersonFromReader(reader);
                people.Add(person);
            }

            return people;
        }

        public Person? GetPersonById(int id)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT [Id], [firstname], [lastname], [age] FROM [Persons] WHERE [Id] = @id";
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var person = MapPersonFromReader(reader);

                return person;
            }

            return null;
        }

        private Person MapPersonFromReader(SqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var firstname = reader.GetString(1);
            var lastname = reader.GetString(2);
            int? age = reader.IsDBNull(3) ? null : reader.GetInt32(3);

            return new Person(id, firstname, lastname, age);
        }
    }
}
