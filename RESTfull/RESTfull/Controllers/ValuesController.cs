using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace RESTfull.Controllers
{
    [RoutePrefix("api1")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("v1")]
        public IHttpActionResult Get1()
        {
            //return BadRequest("sdfsdfsd");
            return Ok(new string[] { "value1", "value2" });
        }
        [HttpGet]
        [Route("v2")]
        // GET api/values/5
        public string Get2()
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
