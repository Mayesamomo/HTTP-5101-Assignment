using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the integer input{num}
        /// </summary>
        /// <param name="num">The number to be squared</param>
        /// <returns>The square of the input number</returns>
        ///
        /// GET:api/square/{num}" -> result
        [HttpGet]
        [Route("api/square/{num}")]
        public int square(int num)
        {
            int result = num * num;
            return result;
        }
    }
}
