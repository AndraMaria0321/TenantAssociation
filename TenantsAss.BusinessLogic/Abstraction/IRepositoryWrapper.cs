namespace TenantsAss.BusinessLogic.Abstraction
{
    public interface IRepositoryWrapper
    {
       IInvoiceRepository InvoiceRepository { get; }
        IBuildingRepository BuildingRepository { get; }
        IApartmentRepository ApartmentRepository { get; }
        void Save();
    }
}
