using System;
using System.Collections.Generic;
using System.Text;
using TenantsAss.DataAccess;
using TenantsAss.DataModel;

namespace TenantsAss.BusinessLogic.Abstractions
{
    public class BuildingRepository : RepositoryBase<Building>, IBuildingRepository
    {
        public BuildingRepository(TenantsAssDbContext tenantsAssDbContext)
            : base(tenantsAssDbContext)
        {
        }
    }
}
