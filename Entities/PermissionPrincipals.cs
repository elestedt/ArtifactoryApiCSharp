using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactoryApiCSharp.Entities
{
    public class PermissionPrincipals
    {
        public PermissionPrincipals()
        {
            this.users = new Dictionary<string, List<string>>();
            this.groups = new Dictionary<string, List<string>>();
        }

        public Dictionary<string, List<string>> users { get; set; }
        public Dictionary<string, List<string>> groups { get; set; }
    }
}
