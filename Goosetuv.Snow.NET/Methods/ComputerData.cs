using RestSharp;
using System.Text.Json;
using Goosetuv.Snow.NET.Classes.Computer;

namespace Goosetuv.Snow.NET.Methods
{
    public class ComputerData
    {
        /// <summary>
        /// Initiates the ComputerData class
        /// </summary>
        /// <param name="AuthenticatedClient">Authenticated RestClient</param>
        public ComputerData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets a list of computers from /api/customers/{cid}/computers.  If skipCount is not used it will only return a total of 100 computers.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Computers to skip, if you have already collected 100 Computers but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 computers without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on Computers class
        /// </returns>
        public Computers Computers(int cid, int skipCount = 0, string additionalParameters = null) 
        {
            return JsonSerializer.Deserialize<Computers>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/computers/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the details of a single computer from /api/customers/{cid}/computers/{computerID}.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="computerID">The Computer ID</param>
        /// <returns>
        ///     Deserialsed Json based on the Computer class
        /// </returns>
        public Computer Computer(int cid, int computerID)
        {
            return JsonSerializer.Deserialize<Computer>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/computers/{computerID}/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets the applications installed on a single computer from /api/customers/{cid}/computers/{computerID}/applications/. If skipCount is not used it will only return a total of 100 applications.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="computerID">The Computer ID</param>
        /// <param name="skipCount">How many Applications to skip, if you have already collected 100 Applications for the device but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Applications without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ComputerApplications class
        /// </returns>
        public ComputerApplications ComputerApplications(int cid, int computerID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ComputerApplications>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/computers/{computerID}/applications/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of Objects that the Computer has assigned to it from /api/customers/{cid}/computers/{computerID}/objects/. If skipCount is not used it will only return a total of 100 Objects.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="computerID">The Computer ID</param>
        /// <param name="skipCount">How many Objects to skip, if you have already collected 100 Objects for the device but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Objects without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialised Json based on the ComputerObjects class
        /// </returns>
        public ComputerObjects ComputerObjects(int cid, int computerID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ComputerObjects>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/computers/{computerID}/objects/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of Users that are assigned/have used the specific computer from /api/customers/{cid}/computers/{computerID}/users/. If skipCount is not used it will only return a total of 100 Users.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="computerID">The Computer ID</param>
        /// <param name="skipCount">How many Users to skip, if you have already collected 100 Users for the device but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Users without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns></returns>
        public ComputerUsers ComputerUsers(int cid, int computerID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ComputerUsers>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/computers/{computerID}/users/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of Virtual Machines that are assigned to a specific computer from customers/{cid}/computers/{computerID}/virtualmachines/. If skipCount is not used it will only return a total of 100 Virtual Machines.
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="computerID">The Computer ID</param>
        /// <param name="skipCount">How many Virtual Machines to skip, if you have already collected 100 Virtual Machines for the device but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Virtual Machines without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns></returns>
        public ComputerVirtualMachines ComputerVirtualMachines(int cid, int computerID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ComputerVirtualMachines>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/computers/{computerID}/virtualmachines/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }
    }
}
