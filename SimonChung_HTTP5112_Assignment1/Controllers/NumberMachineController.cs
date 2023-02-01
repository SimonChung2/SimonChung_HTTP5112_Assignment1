using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_HTTP5112_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method returns 4 numbers derived from a single input when receiving a Get request
        /// The input has 4 mathematical operations applied to it to give 4 outputs
        /// </summary>
        /// <param name="id"></param>
        /// <returns> 4 Values: [id+3, id-2, id*3, id/2] </returns>
        /// <example>
        /// GET api/NumberMachine/10 -> [13,8,30,5]
        /// GET api/NumberMachine/-5 -> [-2,-7,-15,-2.5]
        /// GET api/NumberMachine/30 -> [33,28,90,15]
        /// </example>
        public IEnumerable<double> Get(double id)
        {
            return new double[] { id+3, id-2, id*3, id/2 };
        }
    }
}
