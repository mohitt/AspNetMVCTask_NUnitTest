using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace UnitTestLearnerTask.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public JsonResult Get()
        {
            var rdata=new RowData
            {
                Message = "Hello, World!"
            };

          //  Newtonsoft.Json.JsonConvert.SerializeObject
            return new JsonResult
            {
                Data = rdata,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }


        public class RowData
        {
            public string Message { get; set; }
        }




        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
