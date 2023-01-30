using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment.Controllers
{
   
    public class MathController : ApiController
    {
        [HttpGet]
        [Route("api/math/{id}")]
        public int Get(int id)
        {
            //Todo: summary and finish up the method
            return id; 


        }
    }
}
