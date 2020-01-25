using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Model.Mendeley
{
    public class MendeleySearchResultCollection
    {
        public IEnumerable<MendeleySearchResult> Results { get; private set; }
        public IEnumerable<MendeleyDataType> Filters { get; private set; }
        public int CurrentPage { get; private set; }

        public MendeleySearchResultCollection(IEnumerable<MendeleySearchResult> Results, IEnumerable<MendeleyDataType> Filters)
        {
            this.Results = Results;
            this.Filters = Filters;
            this.CurrentPage = 1;
        }


    }
}
