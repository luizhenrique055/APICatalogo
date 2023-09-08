using System.Collections;
using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriasController : ControllerBase
{
    private readonly AppDbContext _context;

    public CategoriasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("listarComProdutos")]
    public async Task<ActionResult<IEnumerable<Categoria>>> ListarCategoriasComProdutosAsync()
    {
        // include faz referencia a outro objeto, nesse caso chama a categoria
        // junto os produtos dessa categoria
        // necessitando controle de referencia ciclica de serialização
        return await _context.Categorias.Include(p => p.Produtos)
        .Where(p => p.CategoriaId <= 30)
        .ToListAsync();
    }

    [HttpGet("listar")]
    public async Task<ActionResult<IEnumerable<Categoria>>> ListarCategoriasAsync()
    {   
        // AsNoTracking otimiza o retorno das consultas sem alteração
        // Não mapeando as entidades no cache
        return await _context.Categorias.AsNoTracking().ToListAsync();
    }

    [HttpGet("obterPorId/{id:int:min(1)}", Name = "obterPorId")]
    public async Task<ActionResult<Categoria>> Get(int id)
    {
        var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.CategoriaId == id);

        if (categoria is null)
        {
            return NotFound("Categoria não encontrada.");
        }

        return Ok(categoria);
    }

    [HttpPost("criar")]
    public ActionResult CriarCategoria(Categoria categoria)
    {
        if (categoria is null)
        {
            return BadRequest("Categoria vazia.");
        }

        _context.Categorias.Add(categoria);
        _context.SaveChanges();

        return new CreatedAtRouteResult("obterPorId", new { id = categoria.CategoriaId }, categoria);
    }

    [HttpPut("modificar/{id:int}")]
    public ActionResult ModificarCategoria(int id, Categoria categoria)
    {
        if (id != categoria.CategoriaId)
        {
            BadRequest("O Id informado tem problemas. \n 1. Id não existe \n 2. Id informado difere da categoria");
        }

        _context.Entry(categoria).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(categoria);
    }

    [HttpDelete("deletar/{id:int}")]
    public ActionResult<Categoria> DeletarCategoria(int id)
    {
        var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);

        if (categoria is null)
        {
            return NotFound("Categoria não encontrada");
        }

        _context.Categorias.Remove(categoria);
        _context.SaveChanges();

        return Ok("Categoria removida com sucesso!");
    }
}
