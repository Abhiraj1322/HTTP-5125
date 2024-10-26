using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2Controller : ControllerBase
    {  [HttpPost(template: "Epidemiology")]
        [Consumes("application/x-www-form-urlencoded")]
        public int Firstdays([FromForm]int a,[FromForm] int b,[FromForm] int c)
        {
            int totalInfection = b; 
            int currentInfected = b; 
            int day = 0; 
            while (totalInfection <= a)
            {
                day++; 
                currentInfected *= c; 
                totalInfection += currentInfected; 
            }
            return day;
        }

    }
}
