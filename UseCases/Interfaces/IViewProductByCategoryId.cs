using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewProductByCategoryId
    {
        IEnumerable<Product> Execute(int id);
    }
}