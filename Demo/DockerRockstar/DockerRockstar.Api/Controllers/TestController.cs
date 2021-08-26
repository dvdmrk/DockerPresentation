using DockerRockstar.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DockerRockstar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ContainerCounterService _service;
        public TestController(ContainerCounterService service)
        {
            _service = service;
        }

        [HttpGet()]
        public List<ContainerCounter> GetTodoItem()
        {
            var mn = System.Environment.MachineName;
            var container = _service.ContainerCounters.FirstOrDefault(x => x.ContainerId == mn);
            if (container != null)
            {
                container.Count = container.Count + 1;
            }
            else
            {
                _service.ContainerCounters.Add(new ContainerCounter { Count = 1, ContainerId = mn });
            }
            return _service.ContainerCounters;
        }
    }

}