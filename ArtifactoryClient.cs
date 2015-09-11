using ArtifactoryApiCSharp.Api;
using ArtifactoryApiCSharp.Workers;
using RestSharp;
using RestSharp.Authenticators;

namespace ArtifactoryApiCSharp
{
    public class ArtifactoryClient
    {
        private ImprovedRestClient _client;

        public ArtifactoryClient(string baseUrl, string username, string password)
        {
            _client = new ImprovedRestClient(baseUrl, username, password);
            InjectDependencies();
        }



        private void InjectDependencies()
        {
            this.Repositories = new Repositories(_client);
            this.Groups = new Groups(_client);
            this.Permissions = new Permissions(_client);
        }

        public Repositories Repositories { get; private set; }
        public Groups Groups { get; set; }
        public Permissions Permissions { get; set; }
    }
}
