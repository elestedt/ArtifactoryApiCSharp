using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactoryApiCSharp.Entities
{
    public class PermissionTarget
    {
        public PermissionTarget()
        {
            this.includesPattern = "**";
            this.repositories = new List<string>();
            this.principals = new PermissionPrincipals();
        }

        public string name { get; set; }
        public string includesPattern { get; set; }
        public List<string> repositories { get; set; }
        public PermissionPrincipals principals { get; set; }
    }
}
