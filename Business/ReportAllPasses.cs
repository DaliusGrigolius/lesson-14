using System.Collections.Generic;

namespace Business
{
    public class ReportAllPasses
    {
        List<Event> EventList { get; }

        public ReportAllPasses(List<Event> eventList)
        {
            EventList = eventList;
        }

        public List<Event> RetrieveAllEvents()
        {
            return EventList;
        }

        public Event RetrieveEvent(int eventIndex)
        {
            return EventList[eventIndex];
        }
    }

}
