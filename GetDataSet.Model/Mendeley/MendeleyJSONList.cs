using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Model.Mendeley
{
    public class MendeleyJSONList
    {
        public MendeleyJSONRepositoryType repositoryType { get; set; }
        public MendeleyJSONSource source { get; set; }
        public Type type { get; set; }
    }
}
