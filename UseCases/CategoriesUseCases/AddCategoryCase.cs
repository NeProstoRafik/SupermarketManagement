using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;
using UseCases.PlaginInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class AddCategoryCase : IAddCategoryCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public AddCategoryCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }
        public void Execute(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}
