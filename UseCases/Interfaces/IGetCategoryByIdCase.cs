using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetCategoryByIdCase
    {
        Category Execute(int id);
    }
}