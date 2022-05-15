using System;
using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Computer
{
    public class ComputerUsers
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
            public int Id { get; set; }
            public int CustomerId { get; set; }
            public string Username { get; set; }
            public DateTime? LastLogon { get; set; }
            public string FullName { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public int LogonCount { get; set; }
            public bool UserIsAccessible { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
        }
    }
}
