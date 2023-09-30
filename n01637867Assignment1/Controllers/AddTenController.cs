using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01637867Assignment1.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// This method returns an integer 10 more than the integer input {id}, this method accepts Integer positive or negative numbers.
        /// <example> 
        /// GET api/addten/21 -> 31
        /// GET api/addten/0 -> 10
        /// GET api/addten/-9 -> 1
        /// </example>
        /// </summary>
        /// <param name="id">The id is the Input Number, it is integer type and is obtained through the url.</param>
        /// <returns>It returns the value of the Input Number (id) + 10</returns>
        public int Get(int id)
        {
            int add = id + 10;
            return add;
        }
    }
}
