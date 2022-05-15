using System;
using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Application
{
    public class ApplicationsUnderlicensed
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
            public string ManufacturerName { get; set; }
            public int? LicenseRequirement { get; set; }
            public int? LicenseCount { get; set; }
            public int? TransferredLicenseCount { get; set; }
            public int? Compliance { get; set; }
        }
    }
}
