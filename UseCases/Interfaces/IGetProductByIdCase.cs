using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetProductByIdCase
    {
        Product Execute(int id);
    }
}