using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases
{
    public class GetCategoryByIdCase : IGetCategoryByIdCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByIdCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public Category Execute(int id)
        {
            return categoryRepository.GetCatigoriesById(id);
        }
    }
}
