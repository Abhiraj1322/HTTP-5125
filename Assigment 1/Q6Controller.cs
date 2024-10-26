using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// It gives the area of a regular hexagon with side length S.
        /// </summary>
        /// <param name="side">The length of the hexagon side</param>
        /// <returns>
        /// It retuns the area of the hexagon
        /// </returns>
        /// <example>
        /// GET api/q6/hexagon?side=1 -> 2.598076211353316
        /// GET api/q6/hexagon?side=1.5 -> 5.845671475544961
        /// GET api/q6/hexagon?side=20 -> 1039.2304845413264
        /// </example>


        [HttpGet(template: "Hexagone")]
        public double Hexagone(double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return area;

        }
    }
}
