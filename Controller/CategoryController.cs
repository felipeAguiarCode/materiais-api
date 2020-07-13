using Microsoft.AspNetCore.Mvc;
using webAppMaterialControl.Api.Models;
using webAppMaterialControl.Api.Repositories;

namespace webAppMaterialControl.Api.Controllers
{
  [Route("v1/categories")]
  public class CategoryController:Controller
  {
    private readonly ICategoryRepository _repository;

    public CategoryController(ICategoryRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("listar")]
    public JsonResult Listar()
    {
      return Json(_repository.GetAll());
    }

    [HttpGet("consultar/{id:int}")]
    public JsonResult Consultar(int id)
    {
      return Json(_repository.GetById(id));
    }

    [HttpGet("consultar/{id:int}/materials")]
   // public IEnumerable<Material> ListarProdutos(int id)
   // {
   //   return _context.Materials.AsNoTracking().Where(x => x.CategoryId ==id).ToList();
   // }

    [HttpPost("criar")]
    public IActionResult Criar([FromBody] Category category)
    {
        _repository.Create(category);
        return Created("Criado com sucesso", category);
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
      
      _repository.Alter(category);

      return Created("Alterado com sucesso",category);
    }

    [HttpDelete("remover/{id:int}")]
    public IActionResult Remover(int id)
    {
      _repository.Remove(id);
      return Ok("Removido");

    }




    
  }
}