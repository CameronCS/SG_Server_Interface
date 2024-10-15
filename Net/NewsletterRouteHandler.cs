using SG_Server_Interface.Net.RawHandlers;
using SG_Server_Interface.Responses.Newsletters.GetNewsletter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Server_Interface.Net {
    public class NewsletterRouteHandler(string API_URL, string Route) {
        private readonly string API_URL = API_URL;
        private readonly string Route = Route;

        public async Task<GetNewslettersResponse> GetNewsletters() {
            string url = $"{this.API_URL}{this.Route}";
            GetNewslettersResponse @return = await NewsletterHandlerRaw.GetNewsletters(url);
            return @return;
        }
    }
}
