using System.Collections.Generic;
using webAppMaterialControl.Api.Models;

namespace webAppMaterialControl.Api.Repositories
{

  public class CategoryRepository
  {
    public IEnumerable<Category> GetAll()
    {

        var categories = new List<Category>();

          categories.Add( 
              new Category{
                CategoryName = "Ola"
              }
          );

          return categories;
    }

  }

}