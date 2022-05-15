using System;
using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Computer
{
    public class ComputerApplications
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
            public Guid Id { get; set; }
            public string Name { get; set; }
            public Guid? ManufacturerId { get; set; }
            public string ManufacturerName { get; set; }
            public Guid? FamilyId { get; set; }
            public string FamilyName { get; set; }
            public Guid? BundleApplicationId { get; set; }
            public string BundleApplicationName { get; set; }
            public DateTime? LastUsed { get; set; }
            public DateTime? FirstUsed { get; set; }
            public DateTime? InstallDate { get; set; }
            public DateTime? DiscoveredDate { get; set; }
            public int Run { get; set; }
            public int AvgUsageTime { get; set; }
            public int Users { get; set; }
            public bool LicenseRequired { get; set; }
            public bool IsInstalled { get; set; }
            public bool IsBlacklisted { get; set; }
            public bool IsWhitelisted { get; set; }
            public bool IsVirtual { get; set; }
            public bool IsOEM { get; set; }
            public bool IsMSDN { get; set; }
            public bool IsWebApplication { get; set; }
            public double ApplicationItemCost { get; set; }
            public List<Metum> Meta { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
        }
    }
}
