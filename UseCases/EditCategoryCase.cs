﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases
{
    public class EditCategoryCase : IEditCategoryCase
    {
        private readonly ICategoryRepository categoryRepository;

        public EditCategoryCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }
    }
}
