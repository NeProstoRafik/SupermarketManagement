using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Interfaces
{
	public interface ICategoryRepository
	{
		public IEnumerable<Category> GetCatigories();
		void AddCategory(Category category);
		void UpdateCategory(Category category);
		Category GetCatigoriesById(int id);

    }
}
