using System;
using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.DataCenterCluster
{
    public class DataCenterClusters
    {
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

        public string Type { get; set; }
        public List<Metum> Meta { get; set; }
        public List<Link> Links { get; set; }
        public List<Data> Body { get; set; }

        public class Data
        {
            public string Type { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Organization { get; set; }
            public int? ServerCount { get; set; }
            public int? LicensedApplicationCount { get; set; }
            public int? VirtualMachineCount { get; set; }
            public int? InventoriedVirtualMachineCount { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
        }
    }
}
