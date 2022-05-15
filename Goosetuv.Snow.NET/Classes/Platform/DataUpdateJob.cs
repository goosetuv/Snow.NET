using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Goosetuv.Snow.NET.Enums;

namespace Goosetuv.Snow.NET.Classes.Platform
{
    public class DataUpdateJob
    {
        public string Type { get; set; }
        public List<Metum> Meta { get; set; }
        public List<Link> Links { get; set; }
        public Data Body { get; set; }

        public class Context
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class Metum
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public List<Context> Value { get; set; }
        }

        public class Link
        {
            public string Type { get; set; }
            public string Href { get; set; }
            public string Method { get; set; }
            public string Rel { get; set; }
            public string Title { get; set; }
        }

        public class Data
        {
            public string Type { get; set; }

            [JsonPropertyName("State")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public DataUpdateJobState State { get; set; }
            public DateTime? LastStartTime { get; set; }
            public string LastExecutionTime { get; set; }
            public bool? IsRunning { get; set; }
        }
    }
}
