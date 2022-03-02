using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace template_csharp_blog.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext _context;
        public HomeController()
        {
            _context= new ApplicationContext();
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
