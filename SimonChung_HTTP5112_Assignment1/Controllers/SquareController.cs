using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_HTTP5112_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of the input when receiving a get request.
        /// The input is an integer data type while the output is a double data type.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> The square of the input {id} </returns>
        /// <example>  
        /// GET: api/Square/2 ->4
        /// GET: api/Square/-2 ->4
        /// GET: api/Square/10 ->100
        /// </example>

        public double Get(int id)
        {
            return Math.Pow(id, 2);
        }
    }
}
