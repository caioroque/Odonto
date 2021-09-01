using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Odonto.Data;
using Odonto.Models;

namespace Odonto.Controllers
{
    [ApiController]
    [Route("odonto/paciente")]   
    public class PacienteController : ControllerBase
    {
        private readonly DataContext _context;
        public PacienteController(DataContext context)
        {
            _context = context;
        }

        //POST: /odonto/paciente/create
        [Route("create")]
        [HttpPost]
        public Paciente Create(Paciente paciente){

            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            return paciente;
        }
        //POST: /odonto/paciente/list
        [Route("list")]
        [HttpGet]
        public List<Paciente> list() => _context.Pacientes.ToList();

        //POST: /odonto/paciente/delete
        [Route("update")]
        [HttpPost]
        public Paciente Update(Paciente paciente){
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
            return paciente;
        }

        //POST: /odonto/paciente/delete
        [Route("delete")]
        [HttpPost]
        public Paciente Delete(Paciente paciente){
            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();
            return paciente;
        }
    }
}