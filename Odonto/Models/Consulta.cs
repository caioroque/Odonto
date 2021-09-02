using System;

namespace Odonto.Models
{
    public class Consulta
    {
        public Consulta(){}
        public int Id { get; set; }
        public string Nome_consulta { get; set; }
        public string Descricao_Consulta { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
        public Paciente paciente { get; set; }

    }
}