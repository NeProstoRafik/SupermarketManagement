﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;
using UseCases.PlaginInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class DeleteCategoryCase : IDeleteCategoryCase
    {
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategoryCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Delete(int id)
        {
            categoryRepository.DeleteCategory(id);
        }
    }
}
