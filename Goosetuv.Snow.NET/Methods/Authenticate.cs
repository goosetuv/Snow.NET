using RestSharp;
using RestSharp.Authenticators;

namespace Goosetuv.Snow.NET.Methods
{
    public class Authenticate
    {
        /// <summary>
        /// Starts the Authenticator and keeps it in the current application session
        /// </summary>
        /// <param name="BaseURL">The URL of the Snow Platform including /api/</param>
        /// <param name="Username">User account in Snow Management and Configuration Center with API access</param>
        /// <param name="Password">User account password with API access</param>
        /// <returns>
        ///     Authenticated Client
        /// </returns>
        public Authenticate(string BaseURL, string Username, string Password) 
        {
            Client = Authenticator(BaseURL, Username, Password);
        }

        public RestClient Client { get; }

        /// <summary>
        /// Starts the Authenticator and keeps it in the current application session
        /// </summary>
        /// <param name="BaseURL">The URL of the Snow Platform including /api/</param>
        /// <param name="Username">User account in Snow Management and Configuration Center with API access</param>
        /// <param name="Password">User account password with API access</param>
        /// <returns>
        ///     RestSharp Client
        /// </returns>
        internal RestClient Authenticator(string BaseURL, string Username, string Password)
        {
        
            var client = new RestClient($"{BaseURL}")
            {
                Authenticator = new HttpBasicAuthenticator(Username, Password)
            };

            return client;
        }
    }
}
