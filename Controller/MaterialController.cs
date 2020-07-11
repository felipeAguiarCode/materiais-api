using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAppMaterialControl.Api.Data;
using webAppMaterialControl.Api.Models;

namespace webAppMaterialControl.Api.Controllers
{

  [Route("v1/materials")]
  public class MaterialController:Controller
  {

       private readonly MaterialContext _context;

    public MaterialController(MaterialContext context)
    {
        _context = context;
    }

    [HttpGet("listar")]
    public IEnumerable<Material> Listar()
    {
      return _context.Materials.AsNoTracking().ToList();
    }

    [HttpGet("consultar/{id}")]
    public Material Consultar(int id)
    {
      return _context.Materials.AsNoTracking().Where(x => x.CategoryId == id).FirstOrDefault();
    }

    [HttpPost("criar")]
    public IActionResult Criar([FromBody]Material material)
    {
      _context.Materials.Add(material);
      _context.SaveChanges();

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

      return Created("Alterado com sucesso",material);
    }



    [HttpDelete("remover")]
    public IActionResult Remover([FromBody] Material material)
    {
      _context.Materials.Remove(material);
      _context.SaveChanges();

      return Ok("Removido");
    }



  }

}