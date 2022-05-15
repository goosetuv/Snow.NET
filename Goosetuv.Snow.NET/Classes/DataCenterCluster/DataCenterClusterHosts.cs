using System;
using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.DataCenterCluster
{
    public class DataCenterClusterHosts
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
            public int ComputerId { get; set; }
            public string ComputerName { get; set; }
            public DateTime? LastScanDate { get; set; }
            public int VirtualMachines { get; set; }
            public string OperatingSystem { get; set; }
            public string ProcessorType { get; set; }
            public int ProcessorCount { get; set; }
            public int CoresPerProcessor { get; set; }
            public object HypervisorName { get; set; }
        }
    }
}
