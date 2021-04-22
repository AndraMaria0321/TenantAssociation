using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAss.BusinessLogic.Abstractions
{
    public interface IRepositoryWrapper
    {
        IBuildingRepository BuildingRepository { get; }
        IApartmentRepository ApartmentRepository { get; }
        void Save();
    }
}
