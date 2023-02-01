using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_HTTP5112_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns the total hosting cost for web hosting depending on the number of days that elapsed since hosting
        /// began given a rate of $5.50 per fortnight. It calculates the initial cost, the tax, and the total cost. 
        /// </summary>
        /// <param name="id">number of days elapsed</param>
        /// <returns>
        /// 3 strings:
        /// The first states the initial cost
        /// The second states the tax
        /// The third states the total cost
        /// </returns>
        /// <example>
        /// GET api/HostingCost/0  -> "1 fortnights at $5.50/FN = $5.50 CAD", "HST 13% = 0.72 CAD", "Total = $6.22 CAD"
        /// GET api/HostingCost/14 -> "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = 1.43 CAD", "Total = $12.43 CAD" 
        /// GET api/HostingCost/15 -> "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = 1.43 CAD", "Total = $12.43 CAD"
        /// GET api/HostingCost/21 -> "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = 1.43 CAD", "Total = $12.43 CAD"
        /// GET api/HostingCost/28 -> "3 fortnights at $5.50/FN = $16.50 CAD", "HST 13% = 2.15 CAD", "Total = $18.65 CAD"
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            
            double a = Convert.ToDouble(id);                //Converts the input from an integer to a double data type so that data isn't truncated.
                                                            //After performing arithmetic operations on variables.
            double b = a / 14 + 1;                          //Calculates the number of fortnights based on number of days elapsed by dividing by 14.
                                                            //Since a fortnight is being charged on day 0 of a fortnight, 1 is added.
            double c = Math.Floor(b);                       //The number of fortnights is rounded down using the built-in Floor method for the Math object.
            double d = c * 5.50;                            //The initial cost before tax is calculated (no. of fortnights * fortnightly rate).
            string e = String.Format("{0:0.00}", d);        //The output needs to be a string since a string is being returned.
                                                            //The initial cost is converted to a string with the cost being displayed to 2 decimal places.
            double f = 0.13 * d;                            //The tax is calculated (0.13*Initial Cost).
            string g = String.Format("{0:0.00}", f);        //The tax is converted to a string and displayed to 2 decimal places.
            double h = d + f;                               //The total cost is calculated by adding the tax to the initial cost.
            string i = String.Format("{0:0.00}", h);        //The total cost is converted to a string and displayed to 2 decimal places.


            return new string[] {c + " fortnights at $5.50/FN = $" + e + " CAD" , "HST 13% = $" + g, "Total = $" + i + " CAD" }; //The output is assembled using the appropriate variables and strings.
        }
    }
}

