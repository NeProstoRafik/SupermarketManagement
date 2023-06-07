using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IAddProductCase
    {
        void Execute(Product product);
    }
}