using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Computer
{
    public class ComputerVirtualMachines
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
            public int VirtualMachineId { get; set; }
            public int? ComputerId { get; set; }
            public string Name { get; set; }
            public string OperatingSystem { get; set; }
            public object PowerState { get; set; }
            public string IpAddress { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
        }
    }
}
