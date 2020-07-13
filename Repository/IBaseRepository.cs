using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webAppMaterialControl.Api.Repositories
{
  public interface IBaseRepository<Tentity>
  {
      void Alter(Tentity entity);
      Tentity GetById(int id);
      List<Tentity> GetAll();
      void Remove(int id);
      void Create(Tentity entity);
  }
}