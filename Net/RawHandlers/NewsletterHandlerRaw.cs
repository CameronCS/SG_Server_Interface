using SG_Server_Interface.Exceptions;
using SG_Server_Interface.Responses.Newsletters.GetNewsletter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SG_Server_Interface.Net.RawHandlers {
    public class NewsletterHandlerRaw {
        private static HttpClient client = new();

        public static async Task<GetNewslettersResponse> GetNewsletters(string url) {
            HttpResponseMessage res = await client.GetAsync(url)
            ??
            throw new BadResponseExcpetion("Response Came back null please check urls");

            GetNewsletterResponseRaw raw = await res.Content.ReadFromJsonAsync<GetNewsletterResponseRaw>()
            ??
            throw new BadResponseExcpetion("Response Came back null please check urls");

            HttpStatusCode code = res.StatusCode;
            GetNewslettersResponse @return = new(raw, (int)code);
            return @return;
        }
    }
}
