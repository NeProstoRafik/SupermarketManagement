namespace UseCases.Interfaces
{
    public interface ISellProductCase
    {
        void Execute(string cashierName,int id, int qtyToSell);
    }
}