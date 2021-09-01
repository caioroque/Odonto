using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Odonto.Data;
using Odonto.Models;

namespace Odonto.Controllers
{
    [ApiController]
    [Route("odonto/consulta")]  
    public class ConsultaController : ControllerBase
    {
        private readonly DataContext _context;
        public ConsultaController(DataContext context)
        {
            _context = context;
        }

        //POST: /odonto/consulta/create
        [Route("create")]
        [HttpPost]
        public Consulta Create(Consulta consulta){

            _context.Consultas.Add(consulta);
            _context.SaveChanges();
            return consulta;
        }
        //POST: /odonto/consulta/list
        [Route("list")]
        [HttpGet]
        public List<Consulta> list() => _context.Consultas.ToList();

        //POST: /odonto/consulta/delete
        [Route("update")]
        [HttpPost]
        public Consulta Update(Consulta consulta){
            _context.Consultas.Update(consulta);
            _context.SaveChanges();
            return consulta;
        }

        //POST: /odonto/consulta/delete
        [Route("delete")]
        [HttpPost]
        public Consulta Delete(Consulta consulta){
            _context.Consultas.Remove(consulta);
            _context.SaveChanges();
            return consulta;
        }
    }
}
