using System;
using System.Collections.Generic;

namespace Business
{
    public class Event
    {
        public Person Person { get; }
        public DateTime DateTime { get; }

        public Event(Person person, DateTime dateTime)
        {
            Person = person;
            DateTime = dateTime;
        }
    }
}
