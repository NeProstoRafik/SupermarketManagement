using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewProductCase
    {
        IEnumerable<Product> Execute();
    }
}