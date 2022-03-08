using LocationBusiness.Abstract;
using LocationDataAccess.Abstract;
using LocationDataAccess.Concrete;
using LocationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationBusiness.Concrete
{
    public class LocationManager: ILocationService
    {
        private ILocationRepository _locationRepository;

        public LocationManager()
        {
            _locationRepository = new LocationRepository();
        }

        public Location createLocation(Location l)
        {
            return _locationRepository.createLocation(l);
        }

        public void Delete(string id)
        {
            _locationRepository.Delete(id);
        }

        public List<Location> getAllLocations()
        {
            return _locationRepository.getAllLocations();
        }

        public Location getLocationById(string id)
        {
            return _locationRepository.getLocationById(id);
        }

        public Location updateLocation(Location l)
        {
            return _locationRepository.updateLocation(l);
        }
    }
}
