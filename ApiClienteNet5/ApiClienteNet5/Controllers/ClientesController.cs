using ApiClienteNet5.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ApiClienteNet5.Context.AppDbContext;

namespace ApiClienteNet5.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ClientesController : ControllerBase

    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            //AsNoTracking - Método que ajuda a otimizar as consultas, apenas quando não for realizar alterações.
            //ex: return _context.Clientes.AsNoTracking().ToList();

            return _context.Clientes.ToList();
        }
        [HttpGet("{idCli}",Name = "ObterCliente")]
        public ActionResult<Cliente> Get(int idCli)
        {
            //AsNoTracking - Método que ajuda a otimizar as consultas, apenas quando não for realizar alterações.
            //var cliente = _context.Clientes.AsNoTracking().FirstOrDefault(c => c.ID == idCli);

            var cliente = _context.Clientes.FirstOrDefault(c => c.ID == idCli);
            if (cliente == null) 
            {
                return NotFound();
            }
            return cliente;
        }
        [HttpPost]
        public ActionResult Post([FromBody]Cliente cliente) 
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            // OBS: ESTA TRATATIVA NÃO É MAIS NECESSÁRIA A PARTIR DO FRW CORE 2.1

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCliente", new { idCli = cliente.ID }, cliente); 
        }
        [HttpPut("{idCli}")]
        public ActionResult Put(int idCli , [FromBody] Cliente cliente)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            // OBS: ESTA TRATATIVA NÃO É MAIS NECESSÁRIA A PARTIR DO FRW CORE 2.1

            if (idCli != cliente.ID)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{idCli}")]
        public ActionResult<Cliente> Delete (int idCli)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.ID == idCli);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return cliente; 
        }

    }
}
