using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1Controller : ControllerBase
    {

        [HttpPost(template: "Delivedroid")]
        [Consumes("application/x-www-form-urlencoded")]
        public int FinalScore([FromForm] int delivery, [FromForm] int collision)
        {
            int total = delivery * 50 + (collision * -10);
            if (delivery > collision)
            {
                total += 500;
            }
            return total;
        }



    }
}

   

