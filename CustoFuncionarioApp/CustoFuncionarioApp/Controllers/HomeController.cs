using CustoFuncionarioApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustoFuncionarioApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calcular(Funcionario funcionario)
        {
            var custoTotal = funcionario.CalcularCustoTotal();
            ViewBag.CustoTotal = custoTotal;
            return View("Resultado", funcionario);
        }

        public IActionResult Privacy()
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
