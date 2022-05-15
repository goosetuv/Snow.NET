using RestSharp;
using System.Text.Json;
using Goosetuv.Snow.NET.Classes.DataCenterCluster;

namespace Goosetuv.Snow.NET.Methods
{
    public class DataCenterClusterData
    {
        /// <summary>
        /// Initiates the DataCenterClusterData class
        /// </summary>
        /// <param name="AuthenticatedClient">Authenticated RestClient</param>
        public DataCenterClusterData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets the details of a single Data center/cluster from /api/customers/{cid}/dccs/{dccID}
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="dccID">Datacentercluster ID</param>
        /// <returns>
        ///     Deserialsed Json based on the DataCenterCluster class
        /// </returns>
        public DataCenterCluster DataCenterCluster(int cid, int dccID)
        {
            return JsonSerializer.Deserialize<DataCenterCluster>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/dccs/{dccID}/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets a list of all DCCs in the system from /api/customers/{cid}/dccs/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many DCCs to skip, if you have already collected 100 DCCs but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 DCCs without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on DataCenterClusters class in a list
        /// </returns>
        public DataCenterClusters DataCenterClusters(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<DataCenterClusters>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/dccs/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of all licenses assigned to a DCC in the system from /api/customers/{cid}/dccs/{dccID}/licenses/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="dccID">Datacentercluster ID</param>
        /// <param name="skipCount">How many licenses to skip, if you have already collected 100 licenses but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 licenses without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on DataCenterClusterLicenses class in a list
        /// </returns>
        public DataCenterClusterLicenses DataCenterClusterLicenses(int cid, int dccID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<DataCenterClusterLicenses>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/dccs/{dccID}/licenses/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of all hosts assigned to a DCC in the system from /api/customers/{cid}/dccs/licenses/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="dccID">Datacentercluster ID</param>
        /// <param name="skipCount">How many hosts to skip, if you have already collected 100 hosts but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 hosts without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on DataCenterClusterHosts class in a list
        /// </returns>
        public DataCenterClusterHosts DataCenterClusterHosts(int cid, int dccID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<DataCenterClusterHosts>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/dccs/{dccID}/hosts/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }
    }
}
