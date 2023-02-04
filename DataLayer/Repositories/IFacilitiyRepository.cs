using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IFacilitiyRepository:IDisposable
    {
        IEnumerable<Facilities> GetAllFacilities();
        Facilities GetFacilityById(int facilityId);
        bool InsertFacility(Facilities facility);
        bool UpdateFacility(Facilities facility);
        bool DeleteFacility(Facilities facility);
        bool DeleteFacility(int facilityId);
        void Save();
    }
}
