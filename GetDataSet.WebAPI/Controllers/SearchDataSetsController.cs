using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetDataSet.Lib.Mendeley;
using GetDataSet.Model.Mendeley;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetDataSet.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchDataSetsController : ControllerBase
    {
        //TODO: fix this dependency: I plan on consuming different APIs, so MendelJSONResult should inherit from a generalization.
        public IEnumerable<MendeleyJSONResult> Search(string Query)
        {
            return MendeleyRESTConsumer.Search(Query);
        }
    }
}