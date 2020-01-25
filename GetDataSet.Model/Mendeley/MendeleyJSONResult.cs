using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Model.Mendeley
{
    public class MendeleyJSONResult
    {
        public string id { get; set; }
        public string externalId { get; set; }
        public string containerTitle { get; set; }
        public string source { get; set; }
        public DateTime lastImported { get; set; }
        public string containerDescription { get; set; }
        public string doi { get; set; }
        public string publicationDate { get; set; }
        public List<string> containerDataTypes { get; set; }
        public string dateAvailable { get; set; }
        public string repoType { get; set; }
        public string accessRights { get; set; }
        public string containerURI { get; set; }
        public List<string> externalSubjectAreas { get; set; }
        public List<Author> authors { get; set; }
        //TODO: find a JSON that clarifies what type should this be.
        public List<object> assetTypes { get; set; }
        public List<string> snippets { get; set; }

    }
}
