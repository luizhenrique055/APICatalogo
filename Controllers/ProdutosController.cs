using System.Collections.ObjectModel;
using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            var produtos = await _context.Produtos.ToListAsync();

            if (produtos is null)
            {
                return NotFound("Produtos não encontrados.");
            }

            return Ok(produtos);
        }

        [HttpGet("{id:int}", Name = "ObterProduto")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.ProdutoId == id);

            if (produto is null)
            {
                return NotFound("Produto não encontrado.");
            }

            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {

            if (produto is null)
            {
                return BadRequest("Produto não encotrado.");
            }

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
        }


        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (produto is null)
            {
                return BadRequest("Nenhum produto adicionado.");
            }

            if ( id != produto.ProdutoId )
            {
                return BadRequest("Id do produto apresenta erros.\n 1. Id diferente do estoque \n 2.Id inexistente.");
            }

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
            
            return Ok(produto);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var produto = _context.Produtos.FirstOrDefault(p=> p.ProdutoId == id);

            if (produto is null){
                return BadRequest("Produto não localizado para remoção.");
            }

            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok("Produto excluido com exito.");
        }

    }
}
