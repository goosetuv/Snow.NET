using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.User
{
    public class UserComputers
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

        public class DisplayAdapter
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string CurrentResolution { get; set; }
            public string MaxResolution { get; set; }
        }

        public class Monitor
        {
            public string Type { get; set; }
            public string Name { get; set; }
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
            public object OpticalDrives { get; set; }
            public List<DisplayAdapter> DisplayAdapters { get; set; }
            public List<Monitor> Monitors { get; set; }
        }

        public class Data
        {
            public string Type { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Organization { get; set; }
            public int? OrgChecksum { get; set; }
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public string OperatingSystem { get; set; }
            public string OperatingSystemServicePack { get; set; }
            public bool? IsVirtual { get; set; }

            [JsonPropertyName("Status")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public ComputerStatus Status { get; set; }
            public string IpAddresses { get; set; }
            public DateTime? LastScanDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string Domain { get; set; }
            public int? TotalDiskSpace { get; set; }
            public int? PhysicalMemory { get; set; }
            public string ProcessorType { get; set; }
            public int? ProcessorCount { get; set; }
            public int? CoreCount { get; set; }
            public string BiosSerialNumber { get; set; }
            public Hardware Hardware { get; set; }
            public string HypervisorName { get; set; }
            public bool? IsPortable { get; set; }
            public bool? IsServer { get; set; }
            public int? MostFrequentUserId { get; set; }
            public int? MostRecentUserId { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
        }
    }
}
