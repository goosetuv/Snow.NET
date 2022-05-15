using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.Agreement
{
    public class AgreementLicenses
    {
        public string Type { get; set; }
        public List<Metum> Meta { get; set; }
        public List<Link> Links { get; set; }
        public List<Data> Body { get; set; }

        public class Metum
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public object Value { get; set; }
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
            public int Id { get; set; }
            public string ApplicationName { get; set; }
            public string ManufacturerName { get; set; }

            [JsonPropertyName("Metric")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public MetricType? Metric { get; set; }

            [JsonPropertyName("AssignmentType")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public AssignmentType AssignmentType { get; set; }
            public DateTime? PurchaseDate { get; set; }
            public int Quantity { get; set; }
            public bool IsIncomplete { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
        }
    }
}
