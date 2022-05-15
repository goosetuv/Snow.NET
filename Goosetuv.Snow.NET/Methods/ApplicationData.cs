using RestSharp;
using System.Text.Json;
using Goosetuv.Snow.NET.Classes.Application;
using System;

namespace Goosetuv.Snow.NET.Methods
{
    public class ApplicationData
    {
        /// <summary>
        /// Initiates the ApplicationData class
        /// </summary>
        /// <param name="AuthenticatedClient">Authenticated RestClient</param>
        public ApplicationData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets the details of a single application from /api/customers/{cid}/applications/{applicationID}.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="applicationID">The Application ID</param>
        /// <returns>
        ///     Deserialsed Json based on the Application class
        /// </returns>
        public Application Application(int cid, Guid applicationID)
        {
            return JsonSerializer.Deserialize<Application>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/{applicationID}/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets the compliance for a single application from /api/customers/{cid}/applications/{applicationID}/compliance.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="applicationID">The Application ID</param>
        /// <param name="skipCount">How many rows of Compliance to skip, if you have already collected 100 rows of compliance but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 rows of compliance without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationCompliance class in a List
        /// </returns>
        public ApplicationCompliance ApplicationCompliance(int cid, Guid applicationID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ApplicationCompliance>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/{applicationID}/compliance/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the users for a single application from /api/customers/{cid}/applications/{applicationID}/users.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="applicationID">The Application ID</param>
        /// <param name="skipCount">How many Users to skip, if you have already collected 100 users but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Users without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationUsers class in a List
        /// </returns>
        public ApplicationUsers ApplicationUsers(int cid, Guid applicationID, int skipCount = 0, string additionalParameters = null) 
        {
            return JsonSerializer.Deserialize<ApplicationUsers>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/{applicationID}/users/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the Licenses for a single application from /api/customers/{cid}/applications/{applicationID}/licenses.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="applicationID">The Application ID</param>
        /// <param name="skipCount">How many licenses to skip, if you have already collected 100 licenses but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 licenses without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationLicense class in a List
        /// </returns>
        public ApplicationLicense ApplicationLicense(int cid, Guid applicationID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ApplicationLicense>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/{applicationID}/licenses/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the Computers for a single application from /api/customers/{cid}/applications/{applicationID}/computers.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="applicationID">The Application ID</param>
        /// <param name="skipCount">How many Computers to skip, if you have already collected 100 Computers but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Computers without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationComputers class in a List
        /// </returns>
        public ApplicationComputers ApplicationComputers(int cid, Guid applicationID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ApplicationComputers>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/{applicationID}/computers/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets all applications from  /api/customers/{cid}/applications.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Applications to skip, if you have already collected 100 Applications but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Applications without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the Applications class in a List
        /// </returns>
        public Applications Applications(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<Applications>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets all the allowed applications from  /api/customers/{cid}/applications/whitelist.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Applications to skip, if you have already collected 100 Applications but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Applications without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationsAllowList class in a List
        /// </returns>
        public ApplicationsAllowList ApplicationsAllowList(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ApplicationsAllowList>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/whitelist/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets all the denied applications from  /api/customers/{cid}/applications/blacklist.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Applications to skip, if you have already collected 100 Applications but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Applications without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationsDenyList class in a List
        /// </returns>
        public ApplicationsDenyList ApplicationsDenyList(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ApplicationsDenyList>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/blacklist/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets all the overlicensed applications from  /api/customers/{cid}/applications/overlicensed.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Applications to skip, if you have already collected 100 Applications but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Applications without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationsOverlicensed class in a List
        /// </returns>
        public ApplicationsOverlicensed ApplicationsOverlicensed(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ApplicationsOverlicensed>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/overlicensed/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets all the underlicensed applications from  /api/customers/{cid}/applications/underlicensed.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Applications to skip, if you have already collected 100 Applications but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Applications without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ApplicationsUnderlicensed class in a List
        /// </returns>
        public ApplicationsUnderlicensed ApplicationsUnderlicensed(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ApplicationsUnderlicensed>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/applications/underlicensed/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }
    }
}
