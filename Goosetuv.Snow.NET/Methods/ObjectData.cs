using Goosetuv.Snow.NET.Classes.Object;
using RestSharp;
using System;
using System.Text.Json;

namespace Goosetuv.Snow.NET.Methods
{
    public class ObjectData
    {
        /// <summary>
        /// Initiates the ObjectData class
        /// </summary>
        /// <param name="AuthenticatedClient">Authenticated RestClient</param>
        public ObjectData(RestClient AuthenticatedClient)
        {
            _authenticatedClient = AuthenticatedClient;
        }

        internal RestClient _authenticatedClient { get; set; }

        /// <summary>
        /// Gets a list of all Object Types in the system from /api/customers/{cid}/objects/types/
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="skipCount">How many Object Types to skip, if you have already collected 100 Object Types but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Object Types without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on ObjectTypes class in a list
        /// </returns>
        public ObjectTypes ObjectTypes(int cid, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ObjectTypes>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/objects/types/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets a list of all Object Types Objects in the system from /api/customers/{cid}/objects/types/{objectTypeID}
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="objectTypeID">The Object Type ID</param>
        /// <param name="skipCount">How many Objects to skip, if you have already collected 100 Objects but there is 200, then the skipCount would be 100 and so on. Snow only returns 100 Objects without skip.</param>
        /// <param name="additionalParameters">Additional parameters such as $filter, $orderby and $top.</param>
        /// <returns>
        ///     Deserialized Json based on ObjectTypeObjects class in a list
        /// </returns>
        public ObjectTypeObjects ObjectTypeObjects(int cid, int objectTypeID, int skipCount = 0, string additionalParameters = null)
        {
            return JsonSerializer.Deserialize<ObjectTypeObjects>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/objects/types/{objectTypeID}/objects/?$format=json&$inlinecount=allpages&$skip={skipCount}{additionalParameters}")).Result.Content);
        }

        /// <summary>
        /// Gets the details of a single object type from /api/customers/{cid}/objects/types/{objectTypeID}
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="objectTypeID">The Object Type ID</param>
        /// <returns>
        ///     Deserialized Json based on the ObjectType Class
        /// </returns>
        public ObjectType ObjectType(int cid, int objectTypeID)
        {
            return JsonSerializer.Deserialize<ObjectType>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/objects/types/{objectTypeID}/?$format=json")).Result.Content);
        }

        /// <summary>
        /// Gets the details of a single object from /api/custoemrs/{cid}/objects/{objectID}
        /// </summary>
        /// <param name="cid">The Customer ID</param>
        /// <param name="objectID">The Object ID</param>
        /// <returns>
        ///     Deserialized Json based on the Object class
        /// </returns>
        public Classes.Object.Object Object(int cid, int objectID)
        {
            return JsonSerializer.Deserialize<Classes.Object.Object>(_authenticatedClient.ExecuteAsync(new RestRequest($"customers/{cid}/objects/{objectID}/?$format=json")).Result.Content);
        }
    }
}
