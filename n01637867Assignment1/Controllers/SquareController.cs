using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01637867Assignment1.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method returns the square of the integer input {id}, this method accepts Integer positive or negative numbers.
        /// <example>
        /// GET api/square/2 -> 4
        /// GET api/square/-2 -> 4
        /// GET api/square/10 -> 100
        /// </example>
        /// </summary>
        /// <param name="id">The Integer input number given by the url.</param>
        /// <returns>It returns the square of the integer input {id}.</returns>
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
