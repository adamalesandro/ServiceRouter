using System;
using Xunit;
using ServiceRouter.Models;

namespace ServiceRouter.Tests
{
    public class ServiceRegistrationTests
    {

        [Fact(DisplayName = "Can register service")]
        public void CanRegisterService()
        {
            var cache = new ServiceCache();
            cache.Register(new ServiceIdentity { ServiceName = "test", Location = "/" });

            Assert.Equal(1, cache.Keys.Count);
        }

        [Fact(DisplayName = "Register will fail if invalid service name")]
        public void RegisterFailsIfInvalidServiceName()
        {

        }

        [Fact(DisplayName = "Register does not allow a duplicate registration")]
        public void RegisterDoesNotAllowDuplicateRegistration()
        {

        }

        [Fact(DisplayName = "Register() assigns an instance key")]
        public void RegisterAssignsInstanceKey()
        {
            var service = new ServiceIdentity { ServiceName = "FOO" };
            var cache = new ServiceCache();
            cache.Register(service);

            Assert.NotEmpty(service.InstanceKey);
        }
    }
}