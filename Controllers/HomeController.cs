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

    public IActionResult GenerarResultado(SugeridorReceta sugeridor) {
        ViewBag.nombre = sugeridor.nombre;
        ViewBag.edad = sugeridor.calcularEdad();
        ViewBag.platoS = sugeridor.determinarPlato();
        ViewBag.cTiempo = sugeridor.calcularTiempo();
        ViewBag.deterD = sugeridor.determinarDificultad();
        ViewBag.genSaludo = sugeridor.generarSaludo();
        ViewBag.genTip = sugeridor.generarTip();

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
