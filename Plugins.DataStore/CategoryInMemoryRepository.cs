using CoreBusiness;
using UseCases.Interfaces;

namespace Plugins.DataStore
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public CategoryInMemoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category{CategoryId=1, Name="Напитки", Description="Напитки" },
                new Category{CategoryId=2, Name="Закуска", Description="Закуска" },
                new Category{CategoryId=3, Name="Мясо", Description="Мясо" }
            };

        }

        public void AddCategory(Category category)
        {
            if (_categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = _categories.Max(x => x.CategoryId);

            category.CategoryId = maxId + 1;

            _categories.Add(category);
        }

        public IEnumerable<Category> GetCatigories()
        {
            return _categories;
        }

        public Category GetCatigoriesById(int id)
        {
            return _categories?.FirstOrDefault(x => x.CategoryId == id);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = _categories?.FirstOrDefault(x => x.CategoryId == category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }
    }
}