using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controllers : ControllerBase
    {

        /// <summary>
        ///  provide a greeting message with the specified name.
        /// </summary>
        /// <param name="name">The name of the person</param>
        /// <returns>
        ///  returns a string that says "Hi" followed by the specified name.
        /// </returns>
        /// <example>
        /// GET api/q2/greeting?name=Gary -> Hi Gary!
        /// GET api/q2/greeting?name=Ren%C3%A9e -> Hi Renée!
        /// </example>
        [HttpGet(template: "Greeting")]
        public string Greeting(string name)
        {
            return ($"Hi {name}!");
        }
    }
}
