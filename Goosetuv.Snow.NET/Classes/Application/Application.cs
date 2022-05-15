using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.Application
{
    public class Application
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

        public class Allocation
        {
            public string Type { get; set; }
            public string Organization { get; set; }
            public int OrgChecksum { get; set; }

            [JsonPropertyName("Metric")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public MetricType? Metric { get; set; }
            public int LicenseRequirement { get; set; }
            public int Coverage { get; set; }
            public int Compliance { get; set; }
        }

        public class CustomFields
        {
            public string Type { get; set; }
            public string Name { get; set; }

            [JsonPropertyName("DataType")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public CustomFieldDataType DataType { get; set; }
            public string Value { get; set; }
        }

        public class Data
        {
            public string Type { get; set; }
            public Guid Id { get; set; }
            public string Name { get; set; }
            public Guid? ManufacturerId { get; set; }
            public string ManufacturerName { get; set; }
            public string ManufacturerWebsite { get; set; }
            public string LanguageName { get; set; }
            public DateTime? ReleaseDate { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public object Description { get; set; }
            public object SystemOwnerName { get; set; }
            public object SystemOwnerPhone { get; set; }
            public object SystemOwnerEmail { get; set; }
            public object Media { get; set; }
            public bool? IsOperatingSystem { get; set; }

            [JsonPropertyName("OperatingSystemType")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public OperatingSystemType OperatingSystemType { get; set; }
            public List<string> ApplicationTypes { get; set; }
            public List<string> UpgradeOptions { get; set; }
            public List<string> DowngradeOptions { get; set; }
            public int TotalCoverage { get; set; }
            public bool? LicenseRequired { get; set; }
            public int LicenseRequirement { get; set; }
            public int LicenseCount { get; set; }
            public int InstallationCount { get; set; }
            public int BundleInstallationCount { get; set; }
            public int UnusedInstallationCount { get; set; }
            public double UsageFactor { get; set; }
            public int UserCount { get; set; }
            public double Risk { get; set; }
            public double? RiskUnused { get; set; }
            public int Compliance { get; set; }
            public List<Allocation> Allocation { get; set; }
            public object LicenseKeys { get; set; }

            [JsonPropertyName("Metric")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public MetricType? Metric { get; set; }
            public double ApplicationCostTotal { get; set; }
            public double ApplicationCostPerLicense { get; set; }
            public double AverageCostPerLicense { get; set; }
            public double LicenseCostTotal { get; set; }
            public string LicenseCostCurrency { get; set; }
            public double? UserLicenseCost { get; set; }
            public bool? AlertOnOverlicensing { get; set; }
            public bool? AlertOnUnderlicensing { get; set; }
            public bool? AlertWhenNotUsed { get; set; }
            public List<CustomFields> CustomValues { get; set; }
            public bool? SecondaryUseAllowed { get; set; }
            public object MultipleVersionsAllowed { get; set; }
            public object MultipleEditionsAllowed { get; set; }
        }
    }
}
