using Business;
using System.Collections.Generic;

namespace DataAccess
{
    public class PersonRepo
    {
        public List<Person> persons { get; }
        public PersonRepo()
        {
            Person person1 = new Person(1, "Zmogus1");
            Person person2 = new Person(2, "Zmogus2");
            Person person3 = new Person(3, "Zmogus3");
            Person person4 = new Person(4, "Zmogus4");
            Person person5 = new Person(5, "Zmogus4");
            Person person6 = new Person(6, "Zmogus4");
            Person person7 = new Person(7, "Zmogus4");
            Person person8 = new Person(8, "Zmogus4");
            Person person9 = new Person(9, "Zmogus4");
            Person person10 = new Person(10, "Zmogus4");

            List<Person> persons = new List<Person> { person1, person2, person3, person4};
        }
        public List<Person> RetrievePersonsList()
        {
            return persons;
        }
        public Person RetrievePerson(int personIndex)
        {
            return persons[personIndex];
        }
    }
}
