using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.License
{
    public class License
    {
        public string Type { get; set; }
        public List<Metum> Meta { get; set; }
        public List<Link> Links { get; set; }
        public Data Body { get; set; }

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

        public class Context
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class CustomField
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string DataType { get; set; }
            public string Value { get; set; }
        }

        public class Allocation
        {
            public string Type { get; set; }
            public string Organization { get; set; }
            public int Quantity { get; set; }
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
            public AssignmentType? AssignmentType { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public bool? AutomaticDowngrade { get; set; }
            public bool? UpgradeRights { get; set; }
            public string InvoiceReference { get; set; }
            public DateTime? PurchaseDate { get; set; }
            public decimal? PurchasePrice { get; set; }
            public string PurchaseCurrency { get; set; }
            public int? Quantity { get; set; }
            public string Vendor { get; set; }
            public string ExternalId { get; set; }
            public string InstallationMedia { get; set; }
            public string LicenseProofLocation { get; set; }
            public string LicenseKeys { get; set; }
            public string Notes { get; set; }
            public bool? IsIncomplete { get; set; }
            public List<CustomField> CustomFields { get; set; }
            public List<Allocation> Allocations { get; set; }
        }
    }
}
