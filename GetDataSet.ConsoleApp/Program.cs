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
            var Result = MendeleyRESTConsumer.Search("Music");
        }
    }
}
