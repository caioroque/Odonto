using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Odonto.Data;
using Odonto.Models;

namespace Odonto.Controllers
{
    [ApiController]
    [Route("odonto/consultorio")]
    public class ConsultorioController : ControllerBase
    {
        private readonly DataContext _context;
        public ConsultorioController(DataContext context)
        {
            _context = context;
        }

        //POST: /odonto/consultorio/create
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody]Consultorio consultorio){

            _context.Consultorios.Add(consultorio);
            _context.SaveChanges();
            return Created("", consultorio);
        }
        //POST: /odonto/consultorio/list
        [Route("list")]
        [HttpGet]
        public IActionResult list() => Ok(_context.Consultorios.ToList());

        //POST: /odonto/consultorio/uptade
        [Route("update")]
        [HttpPut]
        public IActionResult Update(Consultorio consultorio){
            _context.Consultorios.Update(consultorio);
            _context.SaveChanges();
            return Ok();
        }

        [Route("getbyid/{id}")]
        [HttpGet]
        //POST: /odonto/consultorio/getbyid
        public IActionResult GetById([FromRoute] int id){
            //buscar um objeto pela chave primaria
            Consultorio consultorio = _context.Consultorios.Find(id);
            if (consultorio == null)
            {
                return NotFound();
            }
            return Ok(consultorio);
        }

        //POST: /odonto/consultorio/deletebyid
        [Route("deletebyid")]
        [HttpPost]
        public Consultorio Delete(Consultorio consultorio){
            _context.Consultorios.Remove(consultorio);
            _context.SaveChanges();
            return consultorio;
        }

        [Route("delete/{name}")]
        [HttpDelete]
        //POST: /api/produto/delete
        public IActionResult Delete(string name){
            Consultorio consultorio = _context.Consultorios.FirstOrDefault(consultorio => consultorio.NomeConsultorio == name);
            if (consultorio == null)
            {
                return NotFound();
            }
            _context.Consultorios.Remove(consultorio);
            _context.SaveChanges();
            return Ok(_context.Consultorios.ToList());
        }
    }
}
