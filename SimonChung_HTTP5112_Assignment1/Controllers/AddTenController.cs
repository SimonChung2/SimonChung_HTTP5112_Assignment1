using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_HTTP5112_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method adds 10 to the given input when receiving a get request
        /// </summary>
        /// <param name="id"></param>
        /// <returns> id+10 </returns>
        /// <example> 
        /// GET: api/AddTen/21 ->31
        /// GET: api/AddTen/0 ->10
        /// GET: api/AddTen/-9 ->1
        /// </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
