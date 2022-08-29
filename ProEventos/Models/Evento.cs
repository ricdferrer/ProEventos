namespace ProEventos.Models
{
    public class Evento
    {
        public int EventId { get; set; }
        public string Local { get; set; } = String.Empty;
        public string DataEvento { get; set; } = String.Empty;
        public string Tema { get; set; } = String.Empty;
        public int QuantidadePessoas { get; set; }
        public string Lote { get; set; } = String.Empty;
        public string ImageURL { get; set; } = String.Empty;
    }
}
