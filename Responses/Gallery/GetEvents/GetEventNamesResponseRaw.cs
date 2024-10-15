using System.Text.Json.Serialization;

namespace SG_Server_Interface.Responses.Gallery.GetEvents {
    internal class GetEventNamesResponseRaw {
        [JsonPropertyName("events")]
        public List<string> events {
            get; set;
        }
        [JsonPropertyName("image_paths")]
        public List<string> image_paths {
            get; set;
        }

        [JsonPropertyName("message")]
        public string Message {
            get; set;
        }

        public GetEventNamesResponseRaw(List<string> events, List<string> image_paths, string message) {
            this.events = events;
            this.image_paths = image_paths;
            this.Message = message;
        }
    }
}
