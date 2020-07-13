using Microsoft.AspNetCore.Mvc;
using webAppMaterialControl.Api.Models;
using webAppMaterialControl.Api.Repositories;

namespace webAppMaterialControl.Api.Controllers
{

  [Route("v1/materials")]
  public class MaterialController:Controller
  {

    private readonly IMaterialRepository _repository;

    public MaterialController(IMaterialRepository repository)
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
       var result = _repository.GetById(id);
       return Json(result);
     }

     [HttpPost("criar")]
     public IActionResult Criar([FromBody]Material material)
     {
        _repository.Create(material);

        return Created("Criado com sucesso",material);
     }

     [HttpPut("editar")]
     public IActionResult Editar([FromBody] Material material)
     {
       if(material == null)
       {
         return BadRequest();
       }

       if(!ModelState.IsValid){
         return BadRequest();
       }

       _repository.Alter(material);

       return Created("Alterado com sucesso",material);
     }



     [HttpDelete("remover/{id:int}")]
     public IActionResult Remover(int id)
     {
       _repository.Remove(id);
       return Ok("Removido");

     }



  }

}

