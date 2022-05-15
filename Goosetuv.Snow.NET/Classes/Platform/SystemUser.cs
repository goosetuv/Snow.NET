using System;
using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Platform
{
    public class SystemUser
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

        public class GroupMembership
        {
            public string Type { get; set; }
            public int CustomerId { get; set; }
            public int SystemGroupId { get; set; }
            public string SystemGroupName { get; set; }
        }

        public class ObjectAccess
        {
            public string Type { get; set; }
            public int SystemObjectId { get; set; }
            public string SystemObjectName { get; set; }
        }

        public class Data
        {
            public string Type { get; set; }
            public int Id { get; set; }
            public object CustomerId { get; set; }
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Language { get; set; }
            public object Currency { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public List<GroupMembership> GroupMemberships { get; set; }
            public List<ObjectAccess> ObjectAccess { get; set; }
        }
    }
}
