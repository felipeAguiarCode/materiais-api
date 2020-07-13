using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using webAppMaterialControl.Api.Data;
using webAppMaterialControl.Api.Models;

namespace webAppMaterialControl.Api.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly MaterialContext _context;

        public MaterialRepository(MaterialContext context)
        {
            _context = context;
        }


        public void Alter(Material material)
        {
            _context.Entry<Material>(material).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Create(Material material)
        {
            _context.Materials.Add(material);
            _context.SaveChanges();
        }

        public List<Material> GetAll()
        {
            return _context.Materials.AsNoTracking().ToList();
        }

        public Material GetById(int id)
        {
            return _context.Materials.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(int id)
        {
            var result = _context.Materials.Find(id);

            if (result != null)
            {
                _context.Materials.Remove(result);
                _context.SaveChanges();
            }
        }



    }

}