using System;

namespace webAppMaterialControl.Api.Models
{
  public class Material
  {
    public int Id { get; set; }
    public string Name {get;set;}
    public string Description {get;set;}
    public int Quantity { get; set; }
    public decimal UnitPrice {get;set;}
    public DateTime? CreateDate {get;set;}
    public DateTime? LastUpdateDate {get;set;}
    public int CategoryId {get;set;}
    public Category Category {get;set;}

    

  }

}