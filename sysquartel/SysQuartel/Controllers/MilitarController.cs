using Microsoft.AspNetCore.Mvc;
using SysQuartel.Models;

namespace SysQuartel.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MilitarController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Listar()
    {
        var militar1 = new Militar();
        militar1.Id = 1;
        militar1.Nome = "Francisco Chagas";
        var militar2 = new Militar();
        militar2.Id = 2;
        militar2.Nome = "Moacir Neto";

        var resultado = new { militar1, militar2 };
        return Ok(resultado);
    }

    [HttpPost]
    public async Task<IActionResult> Incluir()
    {
        return Ok("Incluir um novo militar");
    }
}
