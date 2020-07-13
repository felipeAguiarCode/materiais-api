using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAppMaterialControl.Api.Data;
using webAppMaterialControl.Api.Models;

namespace webAppMaterialControl.Api.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly MaterialContext _context;

        public CategoryRepository(MaterialContext context)
        {
            _context = context;
        }

        public void Alter(Category entity)
        {
            _context.Entry<Category>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Create(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.AsNoTracking().ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(int id)
        {
            var result = _context.Categories.Find(id);

            if (result != null)
            {
                _context.Categories.Remove(result);
                _context.SaveChanges();
            }
  
        }


    }

}