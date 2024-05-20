using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SperingTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public async Task<IActionResult> Index() 
        {
        return View();
        }
     
    }
}
