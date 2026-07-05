using Microsoft.AspNetCore.Mvc;

namespace SistemaEmpleados.Controllers;

public class BlazorController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}