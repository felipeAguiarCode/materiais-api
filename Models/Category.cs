using System.Collections.Generic;

namespace webAppMaterialControl.Api.Models
{

public class Category
{
  public int Id {get;set;}
  public string CategoryName {get;set;}
  public IEnumerable<Material> Materials {get;set;}
}

}