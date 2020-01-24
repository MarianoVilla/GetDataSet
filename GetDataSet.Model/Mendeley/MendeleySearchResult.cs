using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Model.Mendeley
{
    public class MendeleySearchResult
    {
        public string Title { get; private set; }
        public string Contributors { get; private set; }
        public DateTime? Date { get; private set; }
        public MendeleyDataType[] DataTypes { get; private set; }
    }
}
