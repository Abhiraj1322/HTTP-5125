using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        ///  tells the secret number by receiving the POST request
        /// </summary>
        /// <param name="num">The secret number</param>
        /// <returns>
        ///  returns the secret number 
        /// </returns>
        /// <example>
        /// POST api/q5/secret
        /// Content-Type: application/json
        /// REQUEST BODY: 5
        /// -> Shh.. the secret is 5
        /// POST api/q5/secret
        /// Content-Type: application/json
        /// REQUEST BODY: -200
        /// -> Shh.. the secret is -200
        /// </example>

        [HttpPost(template: "Secret")]
        public string Secret([FromBody] int num)
        {
            return $"Shh.. the secret is {num}";
        }
    }
}
