using Microsoft.EntityFrameworkCore;
using Odonto.Models;

namespace Odonto.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades de classes de modelo que vão virar as tabelas no banco
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
