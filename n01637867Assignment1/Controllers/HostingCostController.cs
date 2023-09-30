using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01637867Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// This method returns three strings which describe the total hosting cost. In order to show the correct result, 
        /// it was necessary to use data conversion from string to decimal as well as have the concept of adding 
        /// an integer to the division of {i}/14 to obtain the correct number of fortnights.
        /// <example>
        /// GET api/hostingcost/0
        /// GET api/hostingcost/14
        /// GET api/hostingcost/15
        /// GET api/hostingcost/21
        /// GET api/hostingcost/28
        /// </example>
        /// </summary>
        /// <param name="id">The input {id} represents the number of days</param>
        /// <returns>
        /// ["1 fortnights at $5.50/FN = $5.50 CAD","HST 13% = $0.72 CAD","Total = $6.22 CAD"]
        /// ["2 fortnights at $5.50/FN = $11.00 CAD","HST 13% = $1.43 CAD","Total = $12.43 CAD"]
        /// ["2 fortnights at $5.50/FN = $11.00 CAD","HST 13% = $1.43 CAD","Total = $12.43 CAD"]
        /// ["2 fortnights at $5.50/FN = $11.00 CAD","HST 13% = $1.43 CAD","Total = $12.43 CAD"]
        /// ["3 fortnights at $5.50/FN = $16.50 CAD","HST 13% = $2.15 CAD","Total = $18.65 CAD"]
        /// </returns>


        public IEnumerable<string> Get(int id)
        {
            //declare the charge as decimal datatype (m) after the number
            decimal charge = 5.5m;

            /*The division of {id}/14 will only result in the truncation of the integer,
            the plus one is added to obtain the correct value of fortnight*/
            int numfortnight = (id / 14) + 1;

            /*This operation is carried out to obtain the total before taxes,
            to do this the number is truncated to have a maximum of 2 decimals
            ToString("F") will round the nearest decimal number -> 0.054 = 0.05, 0.056 = 0.06)*/
            decimal costFn = Convert.ToDecimal((numfortnight * charge).ToString("F"));

            //decimal type of the hst
            decimal hst = 0.13m;

            //operation to get the taxes and cast to string and decimal
            decimal tax = Convert.ToDecimal((costFn * hst).ToString("#0.00"));

            //operation to get the decimal type of the total hosting cost with 2 decimals
            decimal total = Convert.ToDecimal((costFn + tax).ToString("F"));

            //returning 3 strings with all the required data
            return new string[] { $"{numfortnight} fortnights at $5.50/FN = ${costFn} CAD", $"HST 13% = ${tax} CAD", $"Total = ${total} CAD"};
        }
    }
}
