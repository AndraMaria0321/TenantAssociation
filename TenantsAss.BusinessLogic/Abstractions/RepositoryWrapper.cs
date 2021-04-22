using System;
using System.Collections.Generic;
using System.Text;
using TenantsAss.DataAccess;

namespace TenantsAss.BusinessLogic.Abstractions
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private TenantsAssDbContext _tenantsAssDbContext;
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
