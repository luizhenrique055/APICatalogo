using System.Collections.ObjectModel;
using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("listarProdutos")]
        public async Task<ActionResult<IEnumerable<Produto>>> ListarProdutosAsync()
        {
            var produtos = await _context.Produtos.ToListAsync();

            if (produtos is null)
            {
                return NotFound("Produtos não encontrados.");
            }

            return Ok(produtos);
        }

        [HttpGet("obterProdutoPorId/{id:int}", Name = "obterProdutosPorId")]
        public async Task<ActionResult<Produto>> ObterProdutoPorIdAsync(int id)
        {
            var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.ProdutoId == id);

            if (produto is null)
            {
                return NotFound("Produto não encontrado.");
            }

            return produto;
        }

        [HttpPost("criarProduto")]
        public ActionResult CriarProduto(Produto produto)
        {

            if (produto is null)
            {
                return BadRequest("Produto não encotrado.");
            }

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("obterProdutosPorId", new { id = produto.ProdutoId }, produto);
        }


        [HttpPut("modificarProduto/{id:int}")]
        public ActionResult ModificarProduto(int id, Produto produto)
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

        [HttpDelete("deletarProduto/{id:int}")]
        public ActionResult DeletarProdutoPorId(int id){
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
