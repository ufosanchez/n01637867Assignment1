using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01637867Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns one string when receiving a post request.
        /// <example>
        /// POST api/greeting
        /// </example>
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string Post()
        {
            return "Hello World!";
        }


        /// <summary>
        /// This method returns the string “Greetings to {id} people!” where id is an integer value.
        /// <example>
        /// GET api/greeting/3 -> "Greetings to 3 people!"
        /// GET api/greeting/6 -> "Greetings to 6 people!"
        /// GET api/greeting/0 -> "Greetings to 0 people!"
        /// </example>
        /// </summary>
        /// <param name="id">The Integer input number, which describes the number of people to greet.</param>
        /// <returns>It returns the string “Greetings to {id} people!”, id is the Integer input number.</returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
