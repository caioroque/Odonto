namespace Odonto.Models
{
    public class Consultorio
    {
        public Consultorio(){}
        public int Id { get; set; }
        public string NomeConsultorio { get; set; }
        public Consulta Consulta { get; set; }
    }
}