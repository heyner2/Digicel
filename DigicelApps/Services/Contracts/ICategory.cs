using DigicelApps.Models;
using DigicelApps.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigicelApps.Services
{
    public interface ICategory
    {
        Task<List<Category>> Categories();

        Task<List<CategoryTopDto>> GetTop5();

        Task<Category> GetById(int id);

        Task<Category> GetByName(string name);

        Task<List<Category>> GetByWord(string word);

        Task<bool> Update(Category category);

        Task<bool> Create(CategoryCreationDto category);

        Task<bool> Delete(int id);

        Task<bool> DeleteCategoriesAndApplications(int id);

    }
}
