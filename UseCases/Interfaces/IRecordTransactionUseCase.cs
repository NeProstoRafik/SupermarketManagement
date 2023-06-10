namespace UseCases.Interfaces
{
    public interface IRecordTransactionUseCase
    {
        void Execute(int id, int qty, string cashierName);
    }
}