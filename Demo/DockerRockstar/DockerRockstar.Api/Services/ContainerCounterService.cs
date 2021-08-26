using System.Collections.Generic;

namespace DockerRockstar.Api.Services
{
    public class ContainerCounterService
    {
        public List<ContainerCounter> ContainerCounters;
        public ContainerCounterService()
        {
            ContainerCounters = new List<ContainerCounter>();
        }
    }
    public class ContainerCounter
    {
        public int Count {get;set;}
        public string ContainerId {get;set;}
    }
}