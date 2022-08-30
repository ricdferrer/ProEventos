using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Data;
using ProEventos.Models;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/eventos")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }
        [HttpGet("{id}")]
        public Evento Get([FromRoute] int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventId == id);
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
