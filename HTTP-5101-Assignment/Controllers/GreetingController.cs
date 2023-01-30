using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string "Hellow World!"
        /// </summary>
        /// <returns>{Hellow World!}</returns>
        ///  //get: api/greeting/Greeting -> "Hello World!"
        [HttpPost]
        [Route("api/greeting/")]
        public string Greeting()
        {
         
            string message = "Hello World!";
            return message;
        }

        /// <summary>
        /// Returns the string "Greetings to {id} people!
        /// </summary>
        /// <param name="id">The numer of people to greet</param>
        /// <returns>returns the string "Greetings to {id}</returns>
        [HttpGet]
        [Route("api/greeting/{id}")]
        public string Greeting(int id)
        {
            
            string result = "Greetings to " + id + "people!";
            return result;
        }
    }
}
