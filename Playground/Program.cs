using Playground;
using Playground.Entities;

var repository = new PersonRepository();
var people = repository.GetAllPeople();

Person? personWithId1 = repository.GetPersonById(1);

foreach (var person in people)
{
    Console.WriteLine($"Person: {person.Id} -> {person.FirstName} {person.LastName} : {person.Age}");
}
