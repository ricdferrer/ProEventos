using System.ComponentModel.DataAnnotations;
using System;

namespace ProEventos.API.Models
{
    public class Eventos
    {
        [Key]
        public int EventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImageURL { get; set; }



    }
}