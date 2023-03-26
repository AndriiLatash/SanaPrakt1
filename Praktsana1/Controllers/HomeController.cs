using Microsoft.AspNetCore.Mvc;
using Praktsana1.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace Praktsana1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       

        public IActionResult MyAction()
        {
            
            return View();
        }
        public IActionResult Register(User user)
        {
            return View(user);
        }

    }
}