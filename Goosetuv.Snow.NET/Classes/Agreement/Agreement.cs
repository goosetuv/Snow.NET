using Goosetuv.Snow.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Goosetuv.Snow.NET.Classes.Agreement
{
    /// <summary>
    /// Class for standalone Agreement, for example /api/customers/1/agreements/1/
    /// </summary>
    public class Agreement
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

        public class AgreementPeriod
        {
            public string Type { get; set; }
            public int Id { get; set; }
            public DateTime? ValidFrom { get; set; }
            public DateTime? ValidTo { get; set; }
        }

        public class RestrictedToRoles
        {
            public string Type { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class CustomFields
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
            public int? MasterId { get; set; }
            public string Name { get; set; }
            public string Contractor { get; set; }
            public string ContractorWebsite { get; set; }
            public string ContractorPhone { get; set; }
            public string AgreementType { get; set; }
            public string AgreementNumber { get; set; }
            public DateTime? ActivePeriodFrom { get; set; }
            public DateTime? ActivePeriodTo { get; set; }
            public string Organization { get; set; }
            public bool IsSubscription { get; set; }
            public bool AutomaticLicenseUpgrades { get; set; }
            public int? RenewalDaysBeforeExpiration { get; set; }
            public bool SelectableAfterExpiration { get; set; }
            public bool RestrictedOrganizationAccess { get; set; }
            public bool AlertOnExpiration { get; set; }
            public int AlertWarningDaysBeforeExpiration { get; set; }
            public int AlertCriticalDaysBeforeExpiration { get; set; }
            public bool RestrictedRoleAccess { get; set; }
            public bool AutoAttachComputers { get; set; }
            public List<string> AutoAttachComputersFromOrganizations { get; set; }
            public string ContractorContact { get; set; }
            public string ContractorContactPhone { get; set; }
            public string ContractorContactEmail { get; set; }
            public string LocalContact { get; set; }
            public string LocalContactDepartment { get; set; }
            public string LocalContactPhone { get; set; }
            public string LocalContactEmail { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string Description { get; set; }
            public List<AgreementPeriod> AgreementPeriods { get; set; }
            public List<CustomFields> CustomFields { get; set; }
            public List<RestrictedToRoles> RestrictedToRoles { get; set; }
        }

    }
}
