using LocationDataAccess.Abstract;
using LocationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationDataAccess.Concrete
{

    public class LocationRepository : ILocationRepository
    {


        public Location createLocation(Location l)
        {
            using (var context = new LocationDbContext())
            {
                
                context.Locations.Add(l);
                context.SaveChanges();
                return l;

            }
        }

        public void Delete(string id)
        {
            using (var context = new LocationDbContext())
            {
                var deletedOne = getLocationById(id);
                context.Locations.Remove(deletedOne);
                context.SaveChanges();
            }
        }

        public List<Location> getAllLocations()
        {
            using (var context = new LocationDbContext())
            {
                return context.Locations.ToList();
            }
        }

        public Location getLocationById(string id)
        {
            using (var context = new LocationDbContext())
            {
                return context.Locations.Where(l => l.id == id).SingleOrDefault();
            }
        }

        public Location updateLocation(Location l)
        {
            using (var context = new LocationDbContext())
            {                
                context.Locations.Update(l);
                context.SaveChanges();
                return l;
            }
        }
    }
}
