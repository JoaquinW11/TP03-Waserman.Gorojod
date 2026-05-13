using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_Waserman.Gorojod.Models;

namespace TP03_Waserman.Gorojod.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        SugeridorReceta sugeridor = new SugeridorReceta();
        return View();
    }

    public IActionResult generarResultado() {
        SugeridorReceta sugeridor = new SugeridorReceta();
        ViewBag.platoS = sugeridor.determinarPlato();
        ViewBag.cTiempo = sugeridor.calcularTiempo();
        ViewBag.deterD = sugeridor.determinarDificultad();
        ViewBag.genSaludo = sugeridor.generarSaludo();
        return View();
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
