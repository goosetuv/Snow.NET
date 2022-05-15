using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.Application
{
    public class Applications
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
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
            public Guid Id { get; set; }
            public string Name { get; set; }
            public Guid? ManufacturerId { get; set; }
            public string ManufacturerName { get; set; }
            public Guid? FamilyId { get; set; }
            public string FamilyName { get; set; }

            [JsonPropertyName("OperatingSystemType")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public OperatingSystemType OperatingSystemType { get; set; }
            public int Installations { get; set; }
            public int Users { get; set; }
            public bool LicenseRequired { get; set; }

            [JsonPropertyName("Metric")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public MetricType? Metric { get; set; }
            public bool IsBundle { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }
        }

    }
}
