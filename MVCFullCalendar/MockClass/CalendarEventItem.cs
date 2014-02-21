using System;

namespace MVCFullCalendarICal.MockClass
{
    /// <summary>
    /// http://arshaw.com/fullcalendar/docs/event_data/Event_Object/
    /// This replicates the object that is being used by FulLCalendar
    /// This is merely a DataEntity object you'd use
    /// </summary>
    public class CalendarEventItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsAllDayEvent { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}