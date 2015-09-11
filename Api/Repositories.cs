using ArtifactoryApiCSharp.Entities;
using ArtifactoryApiCSharp.Workers;
using RestSharp;
using System.Collections.Generic;

namespace ArtifactoryApiCSharp.Api
{
    public class Repositories
    {
        private const string REPOSITORIES = "/api/repositories";
        private ImprovedRestClient _client;

        internal Repositories(ImprovedRestClient client)
        {
            _client = client;
        }

        public List<Repository> Get()
        {
            var request = new RestRequest(REPOSITORIES, Method.GET);
            List<Repository> response = _client.Execute<List<Repository>>(request);
            return response;
        }

        public bool Create(LocalRepositoryConfiguration config)
        {
            var request = new RestRequest(REPOSITORIES + "/" + config.key, Method.PUT);
            
            bool response = _client.Execute<LocalRepositoryConfiguration>(request, config);
            return response;
        }
    }
}
