using Microsoft.EntityFrameworkCore;
using webAppMaterialControl.Api.Models;
using webAppMaterialControl.Api.Data.Maps;

namespace webAppMaterialControl.Api.Data
{

  public class MaterialContext: DbContext
  {
    public DbSet<Material> Materials {get;set;}
    public DbSet<Category> Categories {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
          optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=felipeaguiar;Initial Catalog=DBMaterialControl;Data Source=NBQSP-FC594\\SQLEXPRESS");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new CategoryMap());
      modelBuilder.ApplyConfiguration(new MaterialMap());      
    }


  }
}