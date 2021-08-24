using ApiClienteNet5;
using ApiClienteNet5.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApitelefoneNet5.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TelefonesController: ControllerBase

    {
        private readonly AppDbContext _context;

        public TelefonesController(AppDbContext contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Telefone>> Get()
        {
            //AsNoTracking - Método que ajuda a otimizar as consultas, apenas quando não for realizar alterações.
            //ex: return _context.telefones.AsNoTracking().ToList();

            return _context.Telefones.ToList();
        }
    
        [HttpGet("{id}", Name = "Obtertelefone")]
        public ActionResult<Telefone> Get(int id)
        {
            //AsNoTracking - Método que ajuda a otimizar as consultas, apenas quando não for realizar alterações.
            //var telefone = _context.telefones.AsNoTracking().FirstOrDefault(c => c.ID == idCli);

            var telefone = _context.Telefones.FirstOrDefault(t => t.ID == id);
            if (telefone == null)
            {
                return NotFound();
            }
            return telefone;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Telefone telefone)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            // OBS: ESTA TRATATIVA NÃO É MAIS NECESSÁRIA A PARTIR DO FRW CORE 2.1

            _context.Telefones.Add(telefone);
            _context.SaveChanges();

            return new CreatedAtRouteResult("Obtertelefone", new { id = telefone.ID }, telefone);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Telefone telefone)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            // OBS: ESTA TRATATIVA NÃO É MAIS NECESSÁRIA A PARTIR DO FRW CORE 2.1

            if (id != telefone.ID)
            {
                return BadRequest();
            }

            _context.Entry(telefone).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Telefone> Delete(int id)
        {
            var telefone = _context.Telefones.FirstOrDefault(t => t.ID == id);
            if (telefone == null)
            {
                return NotFound();
            }

            _context.Telefones.Remove(telefone);
            _context.SaveChanges();
            return telefone;
        }

    }
}
