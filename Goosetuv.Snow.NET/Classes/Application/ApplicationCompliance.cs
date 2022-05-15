using Goosetuv.Snow.NET.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.Application
{
    public class ApplicationCompliance
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

        public class ComplianceDiscrepancy
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Value { get; set; }
        }

        public class Data
        {
            public string Type { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }

            [JsonPropertyName("MetricName")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public MetricType MetricName { get; set; }
            public int InitialRequirement { get; set; }
            public int AvailableLicenses { get; set; }
            public int? LicenseRequirement { get; set; }
            public int TotalCoverage { get; set; }
            public int? ComplianceCoverage { get; set; }
            public int LicensesPurchased { get; set; }
            public List<ComplianceDiscrepancy> LicenseDiscrepancies { get; set; }
            public List<ComplianceDiscrepancy> LicenseRequirementDiscrepancies { get; set; }
            public List<ComplianceDiscrepancy> LicenseUsedDiscrepancies { get; set; }
        }
    }
}
