using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenantsAss.DataAccess;
using TenantsAss.DataModel;

namespace TenantsAss.BusinessLogic.Abstraction
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private TenantsAssDbContext _tenantsAssDbContext;
        private IInvoiceRepository _invoiceRepository;

        public IInvoiceRepository InvoiceRepository
        {
            get
            {
                if (_invoiceRepository == null)
                {
                    _invoiceRepository = new InvoiceRepository(_tenantsAssDbContext);
                }
                return _invoiceRepository;
            }
        }

        public RepositoryWrapper(TenantsAssDbContext tenantsAssDbContext)
        {
            _tenantsAssDbContext = tenantsAssDbContext;
        }

        public void Save()
        {
            _tenantsAssDbContext.SaveChanges();
        }
    }
}