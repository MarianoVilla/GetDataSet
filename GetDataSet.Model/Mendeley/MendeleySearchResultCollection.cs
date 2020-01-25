using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Model.Mendeley
{
    public class MendeleySearchResultCollection
    {
        //It's rather trivial to keep this. TODO: remove.
        public long ResultsCount { get; private set; }
        public IEnumerable<MendeleySearchResult> Results { get; private set; }
        public IEnumerable<MendeleyDataType> Filters { get; private set; }

        public MendeleySearchResultCollection(IEnumerable<MendeleySearchResult> Results, IEnumerable<MendeleyDataType> Filters)
        {
            this.Results = Results;
            this.Filters = Filters;
            ResultsCount = this.Results.Count();
        }


    }
}
