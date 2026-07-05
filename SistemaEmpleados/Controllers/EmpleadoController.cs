using Microsoft.AspNetCore.Mvc;
using SistemaEmpleados.Models;

namespace SistemaEmpleados.Controllers;

public class EmpleadoController : Controller
{
    public IActionResult Index()
    {
        var lista = new List<Empleado>
        {
            new Empleado { Id = 1, Nombre = "Carlos Manuel Peña",     Departamento = "Ventas",       Salario = 32000m, Activo = true },
            new Empleado { Id = 2, Nombre = "Yolanda Isabel Cruz",    Departamento = "Mercadeo",     Salario = 45500m, Activo = true },
            new Empleado { Id = 3, Nombre = "Rafael Antonio Sánchez", Departamento = "Tecnología",   Salario = 52000m, Activo = false },
            new Empleado { Id = 4, Nombre = "Ana Lucía Fernández",    Departamento = "Contabilidad", Salario = 29500m, Activo = true },
            new Empleado { Id = 5, Nombre = "Miguel Ángel Ramírez",   Departamento = "Logística",    Salario = 26800m, Activo = true },
        };

        return View(lista);
    }
}