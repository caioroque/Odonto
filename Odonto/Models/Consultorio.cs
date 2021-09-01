namespace Odonto.Models
{
    public class Consultorio
    {
        public Consultorio(){}
        public int Id_Consultorio { get; set; }
        public string Nome { get; set; }
        public Consulta Consulta { get; set; }
    }
}