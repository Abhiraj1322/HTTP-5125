using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1controller : ControllerBase
    {
        /// <summary>
        ///  welcoming message by receiving the GET request.
        /// </summary>
        /// <returns>
        /// returns the HTTP response with a body indicating "welcome to 5125!"
        /// </returns>
        /// <example>
        /// GET api/q1/welcome -> "welcome to 5125!"
        /// </example>

        [HttpGet(template: "Welcome")]
        public string Welcome()
        {
            return ("Welcome to 5125!");
        }
 
       
        [HttpGet(template: "Example")]
        public string Example()
        {
            return ("This is Abhiraj.");
        }
    }
}