using System.Collections.Generic;
using webAppMaterialControl.Api.Models;

namespace webAppMaterialControl.Api.Repositories
{
  public class MaterialRepository
  {
    public IEnumerable<Material> GetAll()
    {

        var materials = new List<Material>();

          materials.Add( 
              new Material{
                Name = "Madeira",
              }
          );

          return materials;
    }


  public Material getById()
  {
    return new Material();       
  }

  






  }

}