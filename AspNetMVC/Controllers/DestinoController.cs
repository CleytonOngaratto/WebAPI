using AspNetMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinoController : ControllerBase
    {
        private readonly DestinoDbContext _context;

        public DestinoController(DestinoDbContext context)
        {
            _context = context;
        }


        // GET: api/<DestinoController>
        [HttpGet]
        public IEnumerable<Destinos> GetDestinos()
        {
            return _context.destinos;
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public IActionResult GetDestinoById(int id)
        {
            Destinos destino = _context.destinos.SingleOrDefault(modelo => modelo.ID == id);
            if (destino == null)
            {
                return NotFound();
            }
            return new ObjectResult(destino);
        }

        [HttpPost]
        public IActionResult CriarDestino([FromBody] Destinos item)
        {
            if(item == null)
            {
                return BadRequest();
            }

            _context.destinos.Add(item);
                _context.SaveChanges();

            return new ObjectResult(item);
        }


        [HttpPut("{id}")]
        public IActionResult AtualizaDestino(int id, [FromBody] Destinos item)
        {
            if(id != item.ID)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        [HttpDelete ("{id}")] 
        public IActionResult DeletaDestino(int id)
        {
            var destino = _context.destinos.SingleOrDefault(m => m.ID == id);

                if(destino == null)
            {
                return BadRequest();
            }

            _context.destinos.Remove(destino);
            _context.SaveChanges();
            return Ok(destino);
                   
        }





        
    }
}
