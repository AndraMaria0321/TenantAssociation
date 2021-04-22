using TenantsAss.DataAccess;
using TenantsAss.DataModel;

namespace TenantsAss.BusinessLogic.Abstractions
{
    public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(TenantsAssDbContext tenantsAssDbContext)
            : base(tenantsAssDbContext)
        {
        }
    }
}
