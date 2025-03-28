using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPerson.Context;
using WebApiPerson.Models;

namespace WebApiPerson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ProductoControllers : Controller


    {
        private readonly AppDbContext _context;

        public ProductoControllers(AppDbContext context)
        {
            _context = context;
        }



        [HttpPost]
        public async Task<ActionResult<Producto>> InsertarProducto([FromBody] Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return producto;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> GetProductos()
        {

            return await _context.Productos.ToListAsync();

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {

            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)

            {

                return NotFound();

            }

            return producto;

        }

    }
}
