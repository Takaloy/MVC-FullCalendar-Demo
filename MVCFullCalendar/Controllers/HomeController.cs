using System.Linq;
using System.Web.Mvc;
using MVCFullCalendarICal.MockClass;

namespace MVCFullCalendarICal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", null);
        }

        /// <summary>
        ///     API: http://arshaw.com/fullcalendar/docs/event_data/Event_Object/
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public JsonResult GetCalendarEvents(double start, double end)
        {
            var prospectService = new MockWebServiceCallClass();
            var eventDetails = prospectService.GetCalendarEvents();

            var eventList = from item in eventDetails
                            select new
                                   {
                                       id = item.ID,
                                       title = item.Title,
                                       start = item.Start.ToString("s"),
                                       end = item.End.ToString("s"),
                                       allDay = false,
                                       editable = false
                                   };

            return Json(eventList.ToArray(), JsonRequestBehavior.AllowGet);
        }
    }
}