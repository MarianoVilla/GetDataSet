using GetDataSet.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Test.TestRepo
{
    public class Repo
    {
        public static string GetTestHTML(RepoFiles TheFile)
        {
            return File.ReadAllText(TheFile.ToDescriptionString());
        }
    }
}
