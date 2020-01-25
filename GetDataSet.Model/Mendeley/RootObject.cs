using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Model.Mendeley
{
    public class Result
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
        public List<object> assetTypes { get; set; }
        public List<string> snippets { get; set; }
    }

    public class RepositoryType
    {
        public int ARTICLE_BASED_REPOSITORY { get; set; }
        public int NON_ARTICLE_BASED_REPOSITORY { get; set; }
    }

    public class Type
    {
        public int COLLECTION { get; set; }
        public int PHYSICAL_OBJECT { get; set; }
        public int INTERACTIVE_RESOURCE { get; set; }
        public int VIDEO { get; set; }
        public int DATASET { get; set; }
        public int TEXT { get; set; }
        public int AUDIO { get; set; }
        public int OTHER { get; set; }
        public int SLIDES { get; set; }
        public int SOFTWARE_CODE { get; set; }
        public int GEO_DATA { get; set; }
        public int IMAGE { get; set; }
        public int TABULAR_DATA { get; set; }
        public int DOCUMENT { get; set; }
        public int FILE_SET { get; set; }
        public int WORKFLOW { get; set; }
    }

    public class List
    {
        public RepositoryType repositoryType { get; set; }
        public MendeleyJSONSource source { get; set; }
        public Type type { get; set; }
    }

    public class Facets
    {
        public Range range { get; set; }
        public List list { get; set; }
    }

    public class RootObject
    {
        public List<Result> results { get; set; }
        public Facets facets { get; set; }
        public List<string> promotedResultIds { get; set; }
        public string query { get; set; }
        public int count { get; set; }
        public string versionNumber { get; set; }
    }
}
