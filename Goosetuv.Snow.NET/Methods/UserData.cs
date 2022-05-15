using RestSharp;
using System.Text.Json;
using Goosetuv.Snow.NET.Classes.User;

namespace Goosetuv.Snow.NET.Methods
{
    /// <summary>
    /// Initiates the UserData class
    /// </summary>
    /// <param name="AuthenticatedClient">Authenticated RestClient</param>
    public class UserData
    {
        public UserData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets a list of all Users in the system from /api/customers/{cid}/users/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Users to skip, if you have already collected 100 Users but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Users without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on Users class in a list
        /// </returns>
        public Users Users(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<Users>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/users/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the details of a single user from /api/customers/{cid}/users/{userid}/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="userID">The User ID</param>
        /// <returns>
        ///     Deserialized Json based on the User class
        /// </returns>
        public User User(int cid, int userID)
        {
            return JsonSerializer.Deserialize<User>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/users/{userID}/?$format=json&$inlinecount=allpages")).Result.Content);
        }

        /// <summary>
        /// Gets a list of all Applications a user has used in the system from /api/customers/{cid}/users/{userID}/applications/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="userID">The User ID</param>
        /// <param name="skipCount">How many Applications to skip, if you have already collected 100 Applications but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Applications without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on UserApplications class in a list
        /// </returns>
        public UserApplications UserApplications(int cid, int userID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<UserApplications>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/users/{userID}/applications/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of all Objects assigned to a user from /api/customers/{cid}/users/{userID}/objects/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="userID">The User ID</param>
        /// <param name="skipCount">How many Objects to skip, if you have already collected 100 Objects but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Objects without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on UserObjects class in a list
        /// </returns>
        public UserObjects UserObjects(int cid, int userID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<UserObjects>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/users/{userID}/objects/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of all computers assigned to a user from /api/customers/{cid}/users/{userID}/computers/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="userID">The User ID</param>
        /// <param name="skipCount">How many computers to skip, if you have already collected 100 computers but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 computers without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on UserComputers class in a list
        /// </returns>
        public UserComputers UserComputers(int cid, int userID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<UserComputers>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/users/{userID}/computers/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }
    }
}
