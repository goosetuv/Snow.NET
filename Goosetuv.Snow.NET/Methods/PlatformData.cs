using RestSharp;
using System.Text.Json;
using Goosetuv.Snow.NET.Classes.Platform;
using System;

namespace Goosetuv.Snow.NET.Methods
{
    public class PlatformData : Attribute
    {
        /// <summary>
        /// Initiates the PlatformData class
        /// </summary>
        /// <param name="AuthenticatedClient">Authenticated RestClient</param>
        public PlatformData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets information about the platform and database as well as some 'health check' information like warning from /api/
        /// </summary>
        /// <returns>
        ///     Deserialised Json based on Platform class
        /// </returns>
        public Platform SystemInformation()
        {
            return JsonSerializer.Deserialize<Platform>(_authenticatedClient.ExecuteAsync(new RestRequest("/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets information about the currently logged in user (the API user) from /api/systemusers/loggedin
        /// </summary>
        /// <returns>
        ///     Deserialsed Json based on the SystemUser class
        /// </returns>
        public SystemUser SystemUser()
        {
            return JsonSerializer.Deserialize<SystemUser>(_authenticatedClient.ExecuteAsync(new RestRequest("systemusers/loggedin/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets information about the Customers the current SystemUser has access to in the system from /api/customers/
        /// </summary>
        /// <returns>
        ///     Deserialsed Json based on Customers class
        /// </returns>
        public Customers Customers()
        {
            return JsonSerializer.Deserialize<Customers>(_authenticatedClient.ExecuteAsync(new RestRequest("customers/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets information about the Data Update Job from /api/duj/
        /// </summary>
        /// <returns></returns>
        public DataUpdateJob DataUpdateJob()
        {
            return JsonSerializer.Deserialize<DataUpdateJob>(_authenticatedClient.ExecuteAsync(new RestRequest("duj/?$format=json")).Result.Content);
        }
    }
}
