using GetDataSet.Lib.GeneralLib;
using GetDataSet.Lib.Mendeley;
using GetDataSet.Model.Mendeley;
using System;

namespace GetDataSet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Result = HTTPHandler.GetJSON<MendeleyJSONRootObject>(@"https://data.mendeley.com/api/public_datasets_search?query=music");
        }
    }
}
