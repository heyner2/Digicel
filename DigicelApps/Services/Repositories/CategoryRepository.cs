using AutoMapper;
using DigicelApps.Models;
using DigicelApps.Models.DTOs;
using DigicelApps.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigicelApps.Services.Repositories
{

   
    public class CategoryRepository : ICategory
    {
        private DigicelAppContext _db;
        private readonly IMapper _mapper;
        private IApplication _app;
        public CategoryRepository(DigicelAppContext db, IMapper mapper, IApplication app)
        {
            _db = db;
            _mapper = mapper;
            _app = app;

        }

        public async Task<List<Category>> Categories()
        {
            List<Category> categories = await (from c in _db.Categories select c).ToListAsync();

            return categories;
        }

      public async Task<List<CategoryTopDto>> GetTop5()
        {
            var top =await (from c in _db.Applications group c.Category by c.Name into t select
                                               new CategoryTopDto(t.Key, t.Count())).Take(5).ToListAsync();
            return top;
        }

        public async Task<bool> Create(CategoryCreationDto category)
        {
            try
            {
                var app = _mapper.Map<Category>(category);
                _db.Categories.Add(app);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        

        public async Task<bool> Delete(int id)
        {
            var category = await (from c in _db.Categories where c.Id == id select c).FirstOrDefaultAsync();
            try
            {
                _db.Categories.Remove(category);
                await _db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;

            }
            

        }

        public async Task<bool> DeleteCategoriesAndApplications(int id)
        {
            var apps = await (from a in _db.Applications where a.Category == id select a).ToListAsync();

           

            var category = await(from c in _db.Categories where c.Id == id select c).FirstOrDefaultAsync();
            try
            {
                foreach (var item in apps)
                {
                    _db.Applications.Remove(item);
                }

                _db.Categories.Remove(category);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public async Task<Category> GetById(int id)
        {
            var category = await (from c in _db.Categories where c.Id == id select c).FirstOrDefaultAsync();

            return category;
        }

        public Task<Category> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetByWord(string word)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> Update(Category category)
        {
            var cate =await (from c in _db.Categories where c.Id == category.Id select c).FirstOrDefaultAsync();
            try
            {
                cate.Name = category.Name;
                cate.Description = category.Description;
                return await _db.SaveChangesAsync() > 0 ? true : false;
                
            }
            catch(Exception e)
            {
                 return false;
            }
            

        }
    }
}
