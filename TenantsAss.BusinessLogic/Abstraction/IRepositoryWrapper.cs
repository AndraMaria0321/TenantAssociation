namespace TenantsAss.BusinessLogic.Abstraction
{
    public interface IRepositoryWrapper
    {
       IInvoiceRepository InvoiceRepository { get; }

        void Save();
    }
}
