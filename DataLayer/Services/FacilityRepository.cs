using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer
{
    public class FacilityRepository : IFacilitiyRepository
    {
        SpacePowerResourceContext db = new SpacePowerResourceContext();
        public IEnumerable<Facilities> GetAllFacilities()
        {
            return db.facility;
        }

        public Facilities GetFacilityById(int facilityId)
        {
            return db.facility.Find(facilityId);
        }
        public bool InsertFacility(Facilities facility)
        {
            try
            {
                db.facility.Add(facility);
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool UpdateFacility(Facilities facility)
        {
            try
            {
                db.Entry(facility).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool DeleteFacility(Facilities facility)
        {
            try
            {
                db.Entry(facility).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteFacility(int facilityId)
        {
            try
            {
                var tempFacility = GetFacilityById(facilityId);
                DeleteFacility(tempFacility);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
