using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2ChilliePeperController : ControllerBase
    {
        [HttpGet ( template:"Chilli Pepper ={ingredients}")]
        public int totalspice(string ingredients)
        {
            string[] pepperslist = ingredients.Split(',');
            int total = 0;

            foreach (var pepper in pepperslist)
            {
                switch (pepper)
                {
                    case "Poblano":
                        total += 1500;
                        break;
                    case "Mirasol":
                        total += 6000;
                        break;
                    case "Serrano":
                        total += 15500;
                        break;
                    case "Cayenne":
                        total += 40000;
                        break;
                    case "Thai":
                        total += 75000;
                        break;
                    case "Habanero":
                        total += 125000;
                        break;
                    default:
                       
                        break;
                }
            }
            return total;
        }
    } }

