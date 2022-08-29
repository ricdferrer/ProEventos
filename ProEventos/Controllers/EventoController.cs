using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Models;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/eventos")]
    public class EventoController : ControllerBase
    {
        IEnumerable<Evento> _evento = new Evento[]
        {
                new Evento ()
            {
                EventId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belo Horizonte",
                Lote = "1 Lote",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "foto.png"
            },
                new Evento ()
            {
                EventId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "1 Lote",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yy"),
                ImageURL = "foto.png"
            }
        };
        public EventoController()
        {

        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get([FromRoute] int id)
        {
            return _evento.Where(x => x.EventId == id);
        }
        [HttpPost]
        public string Post()
        {
            return "post";
        }
        [HttpPut]
        public string Put()
        {
            return "put";
        }
        [HttpDelete]
        public string Delete()
        {
            return "delete";
        }
    }
}
