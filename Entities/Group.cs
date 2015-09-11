using Newtonsoft.Json;

namespace ArtifactoryApiCSharp.Entities
{
    public class Group
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool autoJoin { get; set; }
        public string realm { get; set; }
        public string realmAttributes { get; set; }
    }
}
