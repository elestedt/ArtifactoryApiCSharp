using Newtonsoft.Json;
using System.Collections.Generic;

namespace ArtifactoryApiCSharp.Entities
{
    public class LocalRepositoryConfiguration
    {
        public LocalRepositoryConfiguration()
        {
            this.rclass = "local";
            this.includesPattern = "**/*";
            this.excludesPattern = string.Empty;
            this.checksumPolicyType = "client-checksums";
            this.handleReleases = true;
            this.handleSnapshots = true;
            this.snapshotVersionBehaviour = "non-unique";
            this.propertySets = new List<string>();
            this.propertySets.Add("artifactory");
        }

        public string key { get; set; }
        public string rclass { get; set; }
        public string packageType { get; set; }
        public string description { get; set; }
        public string notes { get; set; }
        public string includesPattern { get; set; }
        public string excludesPattern { get; set; }
        public string repoLayoutRef { get; set; }
        public bool debianTrivialLayout { get; set; }
        public string checksumPolicyType { get; set; }
        public bool handleReleases { get; set; }
        public bool handleSnapshots { get; set; }
        public uint maxUniqueSnapshots { get; set; }
        public string snapshotVersionBehaviour { get; set; }
        public string supressPomConsistencyChecks { get; set; }
        public bool blackedOut { get; set; }
        public List<string> propertySets { get; set; }
        public bool archiveBrowsingEnabled { get; set; }
        public bool calculateYumMetadata { get; set; }
        public uint yumRootDepth { get; set; }
    }
}
