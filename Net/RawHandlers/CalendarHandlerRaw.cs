using SG_Server_Interface.Exceptions;
using SG_Server_Interface.Responses.Calendar.GetCalendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SG_Server_Interface.Net.RawHandlers {
    public class CalendarHandlerRaw {
        public static HttpClient client = new();
        public static async Task<GetCalendarEventResponse> GetCalendarEvent(string url) {
            HttpResponseMessage res = await client.GetAsync(url)
            ??
            throw new BadResponseExcpetion("HTTP Response Came Back NULL");

            GetCalendarEventResponseRaw raw = await res.Content.ReadFromJsonAsync<GetCalendarEventResponseRaw>()
            ??
            throw new BadResponseExcpetion("HTTP Response Came Back NULL");

            HttpStatusCode code = res.StatusCode;
            GetCalendarEventResponse @return = new(raw, (int)code);
            return @return;
        }
    }
}
