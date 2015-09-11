using ArtifactoryApiCSharp.Entities;
using ArtifactoryApiCSharp.Workers;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System.Collections.Generic;

namespace ArtifactoryApiCSharp.Api
{
    public class Groups
    {
        private const string GROUPS = "/api/security/groups";
        private ImprovedRestClient _client;

        internal Groups(ImprovedRestClient client)
        {
            _client = client;
        }

        public Group Get(string GroupName)
        {
            var url = GROUPS + "/" + HttpUtility.UrlEncode(GroupName);
            var request = new RestRequest(url, Method.GET);
            var response = _client.Execute<Group>(request);
            return response;
        }

        public bool Create(Group newGroup)
        {
            var url = GROUPS + "/" + HttpUtility.UrlEncode(newGroup.name);
            var request = new RestRequest(url, Method.PUT);
            var response = _client.Execute<Group>(request, newGroup);
            return response;
        }
    }
}
