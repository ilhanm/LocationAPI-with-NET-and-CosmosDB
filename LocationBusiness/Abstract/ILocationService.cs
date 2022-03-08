using LocationDataAccess.Abstract;
using LocationDataAccess.Concrete;
using LocationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationBusiness.Abstract
{
    public interface ILocationService
    {


        List <Location> getAllLocations();
        Location getLocationById(string id);
        
        Location createLocation(Location l);

        Location updateLocation(Location l);

        void Delete(string id);

    }
}
