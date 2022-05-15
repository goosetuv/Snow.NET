using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.Computer
{
    /// <summary>
    /// Class for standalone computer, for example /api/customers/1/computers/4839/
    /// </summary>
    public class Computer
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

        public class LogicalDisk
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string VolumeName { get; set; }
            public int SizeMb { get; set; }
        }

        public class NetworkAdapter
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string IpAddress { get; set; }
            public string MacAddress { get; set; }
        }

        public class OpticalDrive
        {

            public string Type { get; set; }
            public string Name { get; set; }
        }

        public class DisplayAdapter
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string CurrentResolution { get; set; }
            public string MaxResolution { get; set; }
        }

        public class Hardware
        {
            public string Type { get; set; }
            public string BiosSerialNumber { get; set; }
            public string BiosVersion { get; set; }
            public DateTime? BiosDate { get; set; }
            public string ProcessorType { get; set; }
            public int? NumberOfProcessors { get; set; }
            public int? CoresPerProcessor { get; set; }
            public int? PhysicalMemoryMb { get; set; }
            public int? MemorySlots { get; set; }
            public int? MemorySlotsAvailable { get; set; }
            public int? SystemDiskSpaceMb { get; set; }
            public int? SystemDiskSpaceAvailableMb { get; set; }
            public int? TotalDiskSpaceMb { get; set; }
            public int? TotalDiskSpaceAvailableMb { get; set; }
            public List<LogicalDisk> LogicalDisks { get; set; }
            public List<NetworkAdapter> NetworkAdapters { get; set; }
            public List<OpticalDrive> OpticalDrives { get; set; }
            public List<DisplayAdapter> DisplayAdapters { get; set; }
            public object Monitors { get; set; }
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
            public int Id { get; set; }
            public string Name { get; set; }
            public string Manufacturer { get; set; }
            public string ManufacturerWebsite { get; set; }
            public string Model { get; set; }
            public string OperatingSystem { get; set; }
            public string OperatingSystemServicePack { get; set; }
            public string Organization { get; set; }
            public int? OrgChecksum { get; set; }
            public List<string> IpAddresses { get; set; }
            public DateTime? LastScanDate { get; set; }
            public bool? AutoEditing { get; set; }
            public string DatacenterName { get; set; }
            public bool? QuarantineManagement { get; set; }

            [JsonPropertyName("Status")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public ComputerStatus Status { get; set; }
            public DateTime? QuarantineDate { get; set; }
            public DateTime? QuarantineDeleteDate { get; set; }
            public bool? IsPortable { get; set; }
            public bool? IsServer { get; set; }
            public bool? IsVirtual { get; set; }
            public bool? Is64Bit { get; set; }
            public bool? IsPartOfVdi { get; set; }
            public string ClientConfigurationName { get; set; }
            public DateTime? ClientInstallDate { get; set; }
            public string ClientSiteName { get; set; }
            public string ClientVersion { get; set; }
            public string ScannerVersion { get; set; }
            public string Domain { get; set; }
            public string HypervisorName { get; set; }
            public string ScanIdentifier { get; set; }
            public DateTime? TransferDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string Notes { get; set; }
            public string SecurityCode { get; set; }
            public DateTime? PurchaseDate { get; set; }
            public string PurchaseVendor { get; set; }
            public decimal? PurchasePrice { get; set; }
            public string PurchaseCurrency { get; set; }
            public string PurchaseInvoiceReference { get; set; }
            public List<CustomFields> CustomFields { get; set; }
            public Hardware Hardware { get; set; }
        }
    }
}
