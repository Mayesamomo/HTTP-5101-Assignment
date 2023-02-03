using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment.Controllers
{

    public class HostingController : ApiController
    {
        /// <summary>
        /// Calculates the total cost of hosting and maintenance.
        /// </summary>
        /// <param name="id">The number of days counted since the beginning of the hosting</param>
        /// <returns>
        /// The total cost as a currency string.The total cost as a currency string.
        /// </returns>

        [Route("api/hosting/hostingcost/{id}")]
        [HttpGet]
        public string getHostingCost(int id)
        {
            
            // variables
            double baseCost = 5.50; //cost per fortnight {1 fortnight = 14 days}
            double HST = 0.13; 
            double totalCost = (id / 14) * baseCost * (1 + HST);
            if( id >=0 && id < 14)
            {
                totalCost = totalCost + 1;
            }

            else if(id == 14)
            { 
                totalCost =totalCost + 2;
            }
            return  "Total Cost: " + totalCost.ToString();

        }
    }
}
