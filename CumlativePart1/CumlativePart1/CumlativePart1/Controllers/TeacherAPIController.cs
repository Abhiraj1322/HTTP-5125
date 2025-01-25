using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CumlativePart1.Controllers
{
    [Route("api/Teacher")]
    [ApiController]
    public class TeacherAPIController : ControllerBase
    {

        [HttpGet]
        [Route(template: "TeachersName")]

        public string TeachersNames()
        {
            return "A list of Tag name";
        }
    }
}
