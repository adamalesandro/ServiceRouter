using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceRouter.Models;
using ServiceRouter.Exceptions;

namespace ServiceRouter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        public ServicesController()
        {
            _services = new ServiceCache();

            _services.Register(new ServiceIdentity { ServiceName = "positions" });
            _services.Register(new ServiceIdentity { ServiceName = "exposures" });
        }

        private readonly ServiceCache _services;

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => _services.Keys.ToList();

        [HttpGet("{key}")]
        public ActionResult<ServiceIdentity> Get(string key) => _services.Locate(key);

        [HttpPost]
        public ActionResult Register(ServiceIdentity service)
        {
            try
            {
                _services.Register(service);
            }
            catch (ValidationException)
            {

            }
            catch (DuplicateRegistrationException)
            {

            }

            return Created($"/services/{service.ServiceName}", service);
        }
    }
}