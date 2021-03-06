using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Eventos> Get()
        {
            return _context.Eventos;
        }
        [HttpGet("{id}")]
        public Eventos GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete id = {id}";
        }
    }

}
