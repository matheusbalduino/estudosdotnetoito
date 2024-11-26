using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    private readonly ILogger<EventoController> _logger;

    private IEnumerable<Evento> _eventos = [  
            new(){
                EventoId = 1,
                Local = "Floripa",
                DataEvento = "26/11/2024",
                Tema = "Estudos Evento C# .net8",
                QtdPessoas = 30,
                Lote = "lote 1",
                ImagemURL = "URL"

            },
            new(){
                EventoId = 2,
                Local = "Curitiba",
                DataEvento = "26/11/2024",
                Tema = "Estudos Evento C# .net8",
                QtdPessoas = 30,
                Lote = "lote 2",
                ImagemURL = "URL"

            }
        ];

    public EventoController(ILogger<EventoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Get")]
    public IEnumerable<Evento> Get()
    {
        
        _logger.LogInformation("Entramos na aplicação");

        var eventos = _eventos;
       
        return eventos;
    }

    [HttpGet("{id}")]
    [ProducesResponseType<Evento>((int) HttpStatusCode.OK)]
    public IActionResult GetEvento(int id)
    {
        return Ok(_eventos.Where( _ => _.EventoId.Equals(id)));
    }
}
