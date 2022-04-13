using System.Collections.Generic;

namespace Business
{
    public class Report
    {
        public List<Person> Person { get; }
        public List<int> WorkedHours { get; }

        public Report(List<Person> person, List<int> workedHours)
        {
            Person = person;
            WorkedHours = workedHours;
        }

        public List<Person> RetrievePersonsList()
        {
            return Person;
        }

        public Person RetrievePerson(int personIndex)
        {
            return Person[personIndex];
        }

        public List<int> RetrieveWorkedHoursList()
        {
            return WorkedHours;
        }
    }
}
