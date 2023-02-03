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
        /// <summary>
        ///  returns arithmetical simplifcation of the number entered.
        ///  
        /// </summary>
        /// <param name="id">The parameter that takes in user input</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/math/NumberMachine/{id}")]
        public string MathOperation(int id)
        {
            //Todo: summary and finish up the method
            int result1 = id + id; //adds the nummber entered by thesame number 
            int result2 = id * id; // multiplies the input
            int result3 = id - id; //subtracts the input
            int result4 = id / id; //divides the inputs

            string answer = " the operation returns:  " + " \n Addition Operation" +
                result1 +"\n muliplicattion Operation"  + result2 + "\n subtraction  Operation: " + "\n division Operation: " + result3
                + "\n" + "\n" + result4;
            return answer;

        }
    }
}
