using System;
using System.Collections.Generic;

namespace MVCFullCalendarICal.MockClass
{
    public class MockWebServiceCallClass
    {
        public IList<CalendarEventItem> GetCalendarEvents()
        {
            var list = new List<CalendarEventItem>();

            var random = new Random();
            for (int i = -15; i <= 15; i++)
            {
                var start = DateTime.Now.AddDays(i).AddHours(random.Next(-20, 20));
                list.Add
                    (
                        new CalendarEventItem
                        {
                            ID = random.Next(1, 5000),
                            Title = String.Format("Random Title {0}", random.Next(1, 500)),
                            IsAllDayEvent = false,
                            Start = start,
                            End = start.AddHours(random.Next(1, 6))
                        }
                    );
            }
            return list;
        }
    }
}