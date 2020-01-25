using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Model.Mendeley
{
    public class MendeleyJSONRootObject
    {
        public List<MendeleyJSONResult> results { get; set; }
        public MendeleyJSONFacets facets { get; set; }
        public List<string> promotedResultIds { get; set; }
        public string query { get; set; }
        public int count { get; set; }
        public string versionNumber { get; set; }
    }
}
