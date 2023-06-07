using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.PlaginInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategoriesById(int id);
        void DeleteCategory(int id);

    }
}
