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
        private IBuildingRepository _buildingRepository;
        private IApartmentRepository _apartmentRepository;

        public IBuildingRepository BuildingRepository
        {
            get
            {
                if (_buildingRepository == null)
                {
                    _buildingRepository = new BuildingRepository(_tenantsAssDbContext);
                }
                return _buildingRepository;
            }
        }

        public IApartmentRepository ApartmentRepository
        {
            get
            {
                if (_apartmentRepository == null)
                {
                    _apartmentRepository = new ApartmentRepository(_tenantsAssDbContext);
                }
                return _apartmentRepository;
            }
        }

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