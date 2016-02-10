using System;
using System.Collections.Generic;

namespace ArtifactoryApiCSharp.Entities
{
    public class User
    {
        public User()
        {
            this.admin = false;
            this.profileUpdateable = true;
            this.internalPasswordDisabled = false;
            this.groups = new List<string>();
        }

        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }
        public bool profileUpdateable { get; set; }
        public bool internalPasswordDisabled { get; set; }
        public DateTime lastLoggedIn { get; set; }
        public string realm { get; set; }
        public List<string> groups { get; set; }
    }
}
