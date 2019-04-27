using ServiceRouter.Exceptions;
using System;
using System.Collections.Generic;

namespace ServiceRouter.Models
{
    public class ServiceCache : Dictionary<string, ServiceIdentity>
    {
        public void Register(ServiceIdentity service)
        {
            if (string.IsNullOrEmpty(service.ServiceName))
                throw new ValidationException($"ServiceName must be a valid string");

            if (ContainsKey(service.ServiceName))
                throw new DuplicateRegistrationException($"Service {service.ServiceName} is already registered");

            if (string.IsNullOrEmpty(service.InstanceKey))
                service.InstanceKey = Guid.NewGuid().ToString();

            this[service.ServiceName] = service;
        }

        public ServiceIdentity Locate(string serviceName)
        {
            if (this.ContainsKey(serviceName))
                return this[serviceName];

            throw new ServiceNotFoundException($"Could not locate service {serviceName}");
        }
    }
}