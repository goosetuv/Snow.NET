using RestSharp;
using System.Text.Json;
using Goosetuv.Snow.NET.Classes.Agreement;

namespace Goosetuv.Snow.NET.Methods
{
    public class AgreementData
    {
        /// <summary>
        /// Initiates the AgreementData class
        /// </summary>
        /// <param name="AuthenticatedClient">Authenticated RestClient</param>
        public AgreementData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets a list of agreements from /api/customers/{cid}/agreements.  If skipCount is not used it will only return a total of 100 agreements.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Agreements to skip, if you have already collected 100 Agreements but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 agreements without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on Agreements class in a list
        /// </returns>
        public Agreements Agreements(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<Agreements>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/agreements/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the details of a single agreement from /api/customers/{cid}/agreements/{agreementID}.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="agreementID">The Agreement ID</param>
        /// <returns>
        ///     Deserialsed Json based on the Agreement class
        /// </returns>
        public Agreement Agreement(int cid, int agreementID)
        {
            return JsonSerializer.Deserialize<Agreement>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/agreements/{agreementID}/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets a list of sub agreements from /api/customers/{cid}/agreements/{agreementid}/subagreements.  If skipCount is not used it will only return a total of 100 sub agreements.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Sub Agreements to skip, if you have already collected 100 Sub Agreements but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 sub agreements without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on AgreementSubAgreements class in a list
        /// </returns>
        public AgreementSubAgreements SubAgreements(int cid, int agreementID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<AgreementSubAgreements>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/agreements/{agreementID}/subagreements/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of agreement types (incl. Custom) from /api/customers/{cid}/agreements/types.  If skipCount is not used it will only return a total of 100 agreement types.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Agreement Types to skip, if you have already collected 100 Agreement Types but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 agreement types without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on AgreementTypes class in a list
        /// </returns>
        public AgreementTypes AgreementTypes(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<AgreementTypes>(_authenticatedClient.ExecuteAsync(new RestRequest($"/customers/{cid}/agreements/types/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the details of a single Agreement Type from /api/customers/{cid}/agreements/types/{agreementTypeID}.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="agreementTypeID">The Agreement Type ID</param>
        /// <returns>
        ///     Deserialsed Json based on the AgreementType class
        /// </returns>
        public AgreementType AgreementType(int cid, int agreementTypeID)
        {
            return JsonSerializer.Deserialize<AgreementType>(_authenticatedClient.ExecuteAsync(new RestRequest($"/customers/{cid}/agreements/types/{agreementTypeID}/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets a list of computers assigned to a specific agreement from /api/customers/{cid}/agreements/{agreementID}/computers/.  If skipCount is not used it will only return a total of 100 computers.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Computers to skip, if you have already collected 100 Computers but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Computers without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on AgreementComputers class in a list
        /// </returns>
        public AgreementComputers AgreementComputers(int cid, int agreementID, int skipCount, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<AgreementComputers>(_authenticatedClient.ExecuteAsync(new RestRequest($"/customers/{cid}/agreements/{agreementID}/computers/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of objects assigned to a specific agreement from /api/customers/{cid}/agreements/{agreementID}/objects/.  If skipCount is not used it will only return a total of 100 objects.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Objects to skip, if you have already collected 100 Objects but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Objects without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on AgreementObjects class in a list
        /// </returns>
        public AgreementObjects AgreementObjects(int cid, int agreementID, int skipCount, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<AgreementObjects>(_authenticatedClient.ExecuteAsync(new RestRequest($"/customers/{cid}/agreements/{agreementID}/objects/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of Licenses assigned to a specific agreement from /api/customers/{cid}/agreements/{agreementID}/licenses/.  If skipCount is not used it will only return a total of 100 Licenses.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Licenses to skip, if you have already collected 100 Licenses but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Licenses without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on AgreementLicenses class in a list
        /// </returns>
        public AgreementLicenses AgreementLicenses(int cid, int agreementID, int skipCount, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<AgreementLicenses>(_authenticatedClient.ExecuteAsync(new RestRequest($"/customers/{cid}/agreements/{agreementID}/licenses/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Not implemented. Contact on github.com/goosetuv/snow.net if you have mobile data in your system and are willing to assist. 
        /// </summary>
        public AgreementMobileDevices AgreementMobiles()
        {
            throw new System.NotImplementedException();
        }
    }
}
