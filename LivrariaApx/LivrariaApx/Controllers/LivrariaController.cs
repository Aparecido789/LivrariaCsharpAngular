using LivrariaApx.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly ToDoContext _context;

        public LivrariaController(ToDoContext context)
        {
            _context = context;

            _context.todoProducts.Add(new Produto { ID = "1", Nome = "As 48 leis do Poder", Preco = 24.0, Quant = 1, Categoria = "Produtividade", Img = "img1" });
            _context.todoProducts.Add(new Produto { ID = "2", Nome = "book1", Preco = 24.0, Quant = 1, Categoria = "Produtividade", Img = "img1" });
            _context.todoProducts.Add(new Produto { ID = "3", Nome = "book2", Preco = 25.0, Quant = 1, Categoria = "Produtividade", Img = "img1" });
            _context.todoProducts.Add(new Produto { ID = "4", Nome = "book3", Preco = 26.0, Quant = 1, Categoria = "Produtividade", Img = "img1" });
            _context.todoProducts.Add(new Produto { ID = "5", Nome = "book4", Preco = 27.0, Quant = 1, Categoria = "Produtividade", Img = "img1" });

            _context.SaveChanges();
            
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return  _context.todoProducts.ToList();
        }
    }
}
