using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01637867Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// This method takes the input {id} and applies four mathematical operations, I created 4 variables so the result 
        /// of one will be used in the next operation. Additionally, a maximum of 2 decimal places were used. 
        /// The input {id} can be integer or decimal number, if using a decimal remember to add another / after the number.
        /// <example>
        /// GET api/NumberMachine/10 -> 34211.41
        /// GET api/NumberMachine/-5 -> 4703.77
        /// GET api/NumberMachine/30 -> 152333.84
        /// GET api/NumberMachine/-27.5/ -> -315.37
        /// </example>
        /// </summary>
        /// <param name="id">This is the input parameter that accepts integer or decimal number.</param>
        /// <returns>Returns a decimal number up to two decimals which was obtained after a series of operations where the input {id}
        /// was divided by 3; the result of this operation was used for the following operations</returns>


        public decimal Get(double id)
        {

            double division = id/3;
            double addition  = division + 7;
            double multiplication = addition * Math.PI;
            double numPower = Math.Pow(multiplication, 3);

            decimal numPowerCast = Convert.ToDecimal(numPower.ToString("F")); 

            return numPowerCast;
        }
    }
}
