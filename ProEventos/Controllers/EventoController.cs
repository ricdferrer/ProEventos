using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/eventos")]
    public class EventoController : ControllerBase
    {
        private readonly ProEventosContext _context;
        public EventoController(ProEventosContext context)
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
            return _context.Eventos.FirstOrDefault(evento => evento.Id == id);
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
