using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1AController : ControllerBase
    {

        [HttpGet(template: "Del")]
        public List<int> CalculatePressure(int boil)
        {
            int v = (5 * boil) - 400;
            int altitudeLevel;
            if (v > 100)
            {
                altitudeLevel = -1;
            }
            else if (v == 100)
            {
                altitudeLevel = 0;

            }
            else
            {
                altitudeLevel = 1;
            }
            return new List<int> { v, altitudeLevel };
        }

    }
}
