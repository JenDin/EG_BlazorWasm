using System;
using Newtonsoft.Json;

namespace EgeGlutensiz_Frontend.Models
{
	public class HtmlBlock
	{
        public class Body
        {
            public string value { get; set; }
        }

            [JsonProperty("$type")]
            public string type { get; set; }
            public Body body { get; set; }
            public string id { get; set; }
        


    }
}

