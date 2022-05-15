using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.User
{
    public class User
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

        public class CustomField
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
            public int CustomerId { get; set; }
            public string Username { get; set; }
            public string FullName { get; set; }
            public string Organization { get; set; }
            public int OrgChecksum { get; set; }
            public DateTime? LastLogon { get; set; }
            public int LastUsedComputerId { get; set; }
            public string LastUsedComputerName { get; set; }
            public bool? AutoEditing { get; set; }
            public string Email { get; set; }
            public string Location { get; set; }
            public string MobilePhoneNumber { get; set; }
            public string PhoneNumber { get; set; }
            public string RoomNumber { get; set; }

            [JsonPropertyName("StatusCode")]
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public UserStatus StatusCode { get; set; }
            public bool? QuarantineManagement { get; set; }
            public DateTime? QuarantineDate { get; set; }
            public DateTime? QuarantineDeleteDate { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public List<CustomField> CustomFields { get; set; }
        }
    }
}
