using Microsoft.AspNetCore.Mvc;
using PaginaLogin.Models;
using System.Diagnostics;

namespace PaginaLogin.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "SISTEMA";
            home.Password = "candidato123";
            home.Email = "candidato@gmail.com";
            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Logado()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}