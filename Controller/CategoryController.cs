using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAppMaterialControl.Api.Data;
using webAppMaterialControl.Api.Models;
using webAppMaterialControl.Api.Repositories;

namespace webAppMaterialControl.Api.Controllers
{
  [Route("v1/categories")]
  public class CategoryController:Controller
  {
    private readonly MaterialContext _context;

    public CategoryController(MaterialContext context)
    {
        _context = context;
    }

    [HttpGet("listar")]
    public IEnumerable<Category> Listar()
    {
      return _context.Categories.AsNoTracking().ToList();
    }

    [HttpGet("consultar/{id}")]
    public Category Consultar(int id)
    {
      return _context.Categories.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
    }

    [HttpGet("consultar/{id}/materials")]
    public IEnumerable<Material> ListarProdutos(int id)
    {
      return _context.Materials.AsNoTracking().Where(x => x.CategoryId ==id).ToList();
    }

    [HttpPost("criar")]
    public Category Criar([FromBody] Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();

        return category;
    }

    [HttpPut("editar")]
    public IActionResult Editar([FromBody] Category category)
    {
      if (category == null){
        return BadRequest();
      }

      if(!ModelState.IsValid)
      {
        return BadRequest();
      }
      
      _context.Entry<Category>(category).State = EntityState.Modified;
      _context.SaveChanges();

      return Created("Alterado com sucesso",category);
    }

    [HttpDelete("Remover")]
    public IActionResult Remover([FromBody] Category category)
    {

      _context.Categories.Remove(category);
      _context.SaveChanges();

      return Ok("Removido");
    }




    
  }
}