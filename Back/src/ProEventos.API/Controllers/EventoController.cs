using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    private readonly ILogger<EventoController> _logger;
    
    public EventoController(ILogger<EventoController> logger)
    {
        _logger = logger;
    }

    // [HttpGet("{id}")]
    // [ProducesResponseType<Evento>((int) HttpStatusCode.OK)]
    // public IActionResult GetEvento(int id)
    // {
    //     return Ok(_eventos.Where( _ => _.Id.Equals(id)));
    // }
}
