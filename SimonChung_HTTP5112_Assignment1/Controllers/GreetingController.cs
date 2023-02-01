using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_HTTP5112_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string "Hello World!" when receiving a Post request
        /// The output can be seen by entering: <curl -d "" "localhost/api/greeting"> in the terminal
        /// </summary>
        /// <returns> "Hello World!" </returns>
        /// <example> POST api/Greeting -> "Hello World!" </example>
        public string Post()
        {
            return "Hello World!";
        }


        /// <summary>
        /// This method returns the string "Greetings to {id} people!" when receiving a Get request
        /// </summary>
        /// <param name="id"></param>
        /// <returns> 
        /// A string that greets {id} number of people
        /// </returns>
        /// <example>
        /// GET: api/Greeting/3 -> "Greetings to 3 people!"
        /// GET: api/Greeting/6 -> "Greetings to 6 people!"
        /// GET: api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
