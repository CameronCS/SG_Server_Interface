using SG_Server_Interface.Net.RawHandlers;
using SG_Server_Interface.Responses.Calendar.AddCalendar;
using SG_Server_Interface.Responses.Calendar.GetCalendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Server_Interface.Net {
    public class CalendarRouteHandler(string API_URL, string Route) {
        private readonly string API_URL = API_URL;
        private readonly string Route = Route;
        public async Task<GetCalendarEventResponse> GetCalendarEvents() {
            string url = $"{this.API_URL}{this.Route}/get";
            GetCalendarEventResponse @return = await CalendarHandlerRaw.GetCalendarEvent(url);
            return @return;
        }
    }
}
