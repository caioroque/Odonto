namespace Odonto.Models
{
    public class Paciente
    {
        public Paciente(){}
        public int Id_Paciente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string telefone { get; set; }
        public string descricao { get; set; }
        public int idade { get; set; }
        
    }
}