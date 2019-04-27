using System;

namespace ServiceRouter.Models
{
    public class ServiceIdentity
    {
        public string ServiceName { get; set; }
        public string Location { get; set; }
        public string InstanceKey { get; set; }
    }
}