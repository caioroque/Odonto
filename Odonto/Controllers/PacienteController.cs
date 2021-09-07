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
        public IActionResult Create([FromBody]Paciente paciente){

            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            return Created("", paciente);
        }
        //POST: /odonto/paciente/list
        [Route("list")]
        [HttpGet]
        public IActionResult list() => Ok(_context.Pacientes.ToList());

        [Route("getbyid/{id}")]
        [HttpGet]
        //POST: /api/produto/getbyid
        public IActionResult GetById([FromRoute] int id){
            //buscar um objeto pela chave primaria
            Paciente paciente = _context.Pacientes.Find(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente);
        }

        //PUT: /odonto/paciente/updade
        [Route("update")]
        [HttpPut]
        public IActionResult Update([FromBody]Paciente paciente){
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
            return Ok(paciente);
        }
        // DELETAR POR ID
        //POST: /odonto/paciente/deletebyid
        [Route("deletebyid")]
        [HttpPost]
        public Paciente Delete(Paciente paciente){
            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();
            return paciente;
        }

        //DELETAR PELO NOME
        [Route("delete/{Nome}")]
        [HttpDelete]
        //POST: /odonto/paciente/delete
        public IActionResult Delete(string Nome){
            Paciente paciente = _context.Pacientes.FirstOrDefault(paciente => paciente.Nome == Nome);
            if (paciente == null)
            {
                return NotFound();
            }
            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();
            return Ok(_context.Pacientes.ToList());
        }
    }
}