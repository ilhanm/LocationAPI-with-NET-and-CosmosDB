using LocationBusiness.Abstract;
using LocationBusiness.Concrete;
using LocationEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        private ILocationService locationService;

        public LocationController()
        {
            locationService = new LocationManager();
        }

        [HttpGet]
        public List<Location> Get()
        {
            return locationService.getAllLocations();
        }

        [HttpGet("{id}")]
        public Location Get(string id)
        {
            return locationService.getLocationById(id);
        }

        [HttpPost]
        public Location Post(Location location)
        {
            return locationService.createLocation(location);
        }

        [HttpPut]
        public Location Put(Location location)
        {
            return locationService.updateLocation(location);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            locationService.Delete(id);
        }


    }
}
