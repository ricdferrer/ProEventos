using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento()
            {
                EventoId = 1,
                Tema = "Angular e suas novidades",
                Lote = "2 Lote",
                QtdPessoas = 25,
                DataEvento = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                ImageURL = "teste.png"
            },
                new Evento()
            {
                EventoId = 2,
                Tema = "Angular 11 e .Net 5",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
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
        public IEnumerable<Evento> GetById(int id) {
            return _evento.Where( e => e.EventoId == id );
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
