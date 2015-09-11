using ArtifactoryApiCSharp.Entities;
using ArtifactoryApiCSharp.Workers;
using RestSharp;
using System.Collections.Generic;

namespace ArtifactoryApiCSharp.Api
{
    public class Permissions
    {
        private const string PERMISSIONS = "/api/security/permissions";
        private ImprovedRestClient _client;

        internal Permissions(ImprovedRestClient client)
        {
            _client = client;
        }

        public bool Create(PermissionTarget config)
        {
            var request = new RestRequest(PERMISSIONS + "/" + config.name, Method.PUT);
            bool response = _client.Execute<PermissionTarget>(request, config);
            return response;
        }
    }
}
