using RestSharp;
using System.Text.Json;
using Goosetuv.Snow.NET.Classes.License;

namespace Goosetuv.Snow.NET.Methods
{
    public class LicenseData
    {
        /// <summary>
        /// Initiates the LicenseData class
        /// </summary>
        /// <param name="AuthenticatedClient">Authenticated RestClient</param>
        public LicenseData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets a list of Licenses entered by a customer from /api/customers/{cid}/licenses/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="licenseID">The License ID</param>
        /// <param name="skipCount">How many Licenses to skip, if you have already collected 100 Licenses but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Licenses without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on the Licenses class in a list
        /// </returns>
        public Licenses Licenses(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<Licenses>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/licenses/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the details of a single license from /api/customers/{cid}/licenses/{licenseID}
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="licenseID">The License ID</param>
        /// <returns>
        ///     Deserialized Json based on the License class
        /// </returns>
        public License License(int cid, int licenseID)
        {
            return JsonSerializer.Deserialize<License>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/licenses/{licenseID}/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets a list of Licenses that are the base of an upgrade from /api/customers/{cid}/licenses/{licenseID}/baselicenses
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="licenseID">The License ID</param>
        /// <param name="skipCount">How many Licenses to skip, if you have already collected 100 Licenses but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Licenses without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on the LicenseBaseLicenses class in a list
        /// </returns>
        public LicenseBaseLicenses LicenseBaseLicenses(int cid, int licenseID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<LicenseBaseLicenses>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/licenses/{licenseID}/baselicenses/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of Licenses that are being upgraded off of a base License from /api/customers/{cid}/licenses/{licenseID}/upgradinglicenses/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="licenseID">The License ID</param>
        /// <param name="skipCount">How many Licenses to skip, if you have already collected 100 Licenses but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Licenses without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on the LicenseUpgradingLicenses class in a list
        /// </returns>
        public LicenseUpgradingLicenses LicenseUpgradingLicenses(int cid, int licenseID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<LicenseUpgradingLicenses>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/licenses/{licenseID}/upgradinglicenses/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of Virtual Machines a license is assigned to from /api/customers/{cid}/licenses/{licenseID}/virtualmachines/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="licenseID">The License ID</param>
        /// <param name="skipCount">How many VMs to skip, if you have already collected 100 VMs but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 VMs without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on the LicenseVirtualMachines class in a list
        /// </returns>
        public LicenseVirtualMachines LicenseVirtualMachines(int cid, int licenseID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<LicenseVirtualMachines>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/licenses/{licenseID}/virtualmachines/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }
    }
}
