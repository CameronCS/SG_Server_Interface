using SG_Server_Interface.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Server_Interface.Responses.Gallery.GetYears {
    internal class GetYearResponseRaw {
        public List<GalleryYear> results {
            get; set;
        }

        public string message {
            get; set;
        }

        public GetYearResponseRaw(List<GalleryYear> results, string message) {
            this.results = results;
            this.message = message;
        }
    }
}
