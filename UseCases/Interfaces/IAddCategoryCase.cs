using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IAddCategoryCase
    {
        void Execute(Category category);
    }
}