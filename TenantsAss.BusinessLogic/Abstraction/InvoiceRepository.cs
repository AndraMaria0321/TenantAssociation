using TenantsAss.DataAccess;
using TenantsAss.DataModel;

namespace TenantsAss.BusinessLogic.Abstraction
{
    public class InvoiceRepository : RepositoryBase<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(TenantsAssDbContext tenantsAssDbContext)
            : base(tenantsAssDbContext)
        {
        }
    }
}
