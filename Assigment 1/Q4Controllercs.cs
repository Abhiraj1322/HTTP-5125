using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controllercs : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request and provides a message.
        /// </summary>
        /// <returns>
        /// It returns a message like "Who's there?"
        /// </returns>
        /// <example>
        /// POST api/q4/knockknock -> Who's there?
        /// </example>
        /// 
        ///   /// <summary>
        /// Receives an HTTP POST request and provides a message.
        /// </summary>
        /// <returns>
        /// It returns a message like "Too lazy to answer!"
        /// </returns>
        /// <example>
        /// POST api/q4/example -> Too lazy to answer!
        /// </example>
        /// 
        [HttpPost(template: "Knockknock")]
        public string Knockknock()
        {
            return ("Who's there?");
        }

        
        [HttpPost(template: "example")]
        public string example()
        {
            return ("Too lazy to answer!");
        }
    }
}
