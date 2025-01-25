using Microsoft.AspNetCore.Mvc;

namespace C__Cumulative_Part_1.Models
{
    public class TeacherDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
