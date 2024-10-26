using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        ///  gives the current date adjusted by the specified number of days, formatted as yyyy-MM-dd
        /// </summary>
        /// <param name="days">The number of days to adjust the current date by</param>
        /// <returns>
        ///  returns the date in yyyy-MM-dd format
        /// </returns>
        /// <example>
        /// GET api/q7/timemachine?days=1 -> 2024-09-28
        /// GET api/q7/timemachine?days=-1 -> 2024-09-26
        /// </example>


        [HttpGet(template: "Timemachine")]
        public string Timemachine(int days)
        {
            DateTime CurrentDate = DateTime.Today;
            DateTime CalculatedDays = CurrentDate.AddDays(days);
            return CalculatedDays.ToString("yyyy-MM-dd");
        }


    }
}
