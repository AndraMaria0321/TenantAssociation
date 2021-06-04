using TenantsAss.DataAccess;
using TenantsAss.DataModel;

namespace TenantsAss.BusinessLogic.Abstraction
{
    public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(TenantsAssDbContext tenantsAssDbContext)
            : base(tenantsAssDbContext)
        {
        }
    }
}
