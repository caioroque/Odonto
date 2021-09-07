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
        public IActionResult Create([FromBody]Consulta consulta){

            _context.Consultas.Add(consulta);
            _context.SaveChanges();
            return Created("", consulta);
        }
        //POST: /odonto/consulta/list
        [Route("list")]
        [HttpGet]
        public IActionResult list() => Ok(_context.Consultas.ToList());

        [Route("getbyid/{id}")]
        [HttpGet]
        //POST: /odonto/consulta/getbyid
        public IActionResult GetById([FromRoute] int id){
            //buscar um objeto pela chave primaria
            Consulta consulta = _context.Consultas.Find(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return Ok(consulta);
        }

        //POST: /odonto/consulta/delete
        [Route("update")]
        [HttpPut]
        public IActionResult Update(Consulta consulta){
            _context.Consultas.Update(consulta);
            _context.SaveChanges();
            return Ok();
        }

        //POST: /odonto/consulta/deletebyid
        [Route("deletebyid")]
        [HttpPost]
        public Consulta Delete(Consulta consulta){
            _context.Consultas.Remove(consulta);
            _context.SaveChanges();
            return consulta;
        }

        [Route("delete/{name}")]
        [HttpDelete]
        //DELETE: /odonto/consulta/delete
        public IActionResult Delete(string name){
            Consulta consulta = _context.Consultas.FirstOrDefault(consulta => consulta.Nome_consulta == name);
            if (consulta == null)
            {
                return NotFound();
            }
            _context.Consultas.Remove(consulta);
            _context.SaveChanges();
            return Ok(_context.Consultas.ToList());
        }
    }
}
