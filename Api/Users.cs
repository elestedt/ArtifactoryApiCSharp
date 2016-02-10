using ArtifactoryApiCSharp.Entities;
using ArtifactoryApiCSharp.Workers;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System.Collections.Generic;

namespace ArtifactoryApiCSharp.Api
{
    public class Users
    {
        private const string USERS = "/api/security/users";
        private ImprovedRestClient _client;

        internal Users(ImprovedRestClient client)
        {
            _client = client;
        }

        public Dictionary<string, string> GetList(string User)
        {
            var url = USERS;
            var request = new RestRequest(url, Method.GET);
            var response = _client.Execute<Dictionary<string, string>>(request);
            return response;
        }

        public bool Create(User newUser)
        {
            var url = USERS + "/" + HttpUtility.UrlEncode(newUser.name);
            var request = new RestRequest(url, Method.PUT);
            var response = _client.Execute<User>(request, newUser);
            return response;
        }
    }
}
