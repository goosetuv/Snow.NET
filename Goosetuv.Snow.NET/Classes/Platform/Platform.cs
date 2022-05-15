using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Platform
{
    /// <summary>
    /// Information available on the /api/ overview page
    /// </summary>
    public class Platform
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

        public class Data
        {
            public string Type { get; set; }
            public string Product { get; set; }
            public string ApiVersion { get; set; }
            public string AppVersion { get; set; }
            public string DbSchemaVersion { get; set; }
            public string DbServer { get; set; }
            public string DbServerVersion { get; set; }
            public string DbCatalog { get; set; }
            public string DbUser { get; set; }
            public List<object> Warnings { get; set; }
            public List<string> Hints { get; set; }
        }
    }
}
