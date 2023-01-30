using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment.Controllers
{
    public class AdditionController : ApiController
    {
        /// <summary>
        /// This method takes in a number and adds 10 to the numer it then 
        /// return the addition of both
        /// </summary>
        /// <param name="ten">The parameter that taks in user input</param>
        /// <returns>Returns the addition of the input + 10</returns>
        /// GET: api/addition/{ten} -> result
        [HttpGet]
        [Route("api/addition/{ten}")]
        public  int AddTen(int ten)
        {

            int result = ten + 10;
            return result;
        }
    }
}
