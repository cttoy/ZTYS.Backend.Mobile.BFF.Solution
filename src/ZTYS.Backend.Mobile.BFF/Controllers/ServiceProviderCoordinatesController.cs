using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZTYS.Backend.Mobile.BFF.Models;
using Microsoft.Extensions.Logging;

namespace ZTYS.Backend.Mobile.BFF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceProviderCoordinatesController : ControllerBase
    {
        private readonly ILogger<ServiceProviderCoordinatesController> _logger;

        public ServiceProviderCoordinatesController(ILogger<ServiceProviderCoordinatesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ServiceProviderCoordinates> Get(string serviceType)
        {
            var list = new List<ServiceProviderCoordinates>()
            {
                new ServiceProviderCoordinates
                {
                    Id = "1",
                    Title = "中国石化（沂水第82加油站）",
                    Address = "山东省临沂市沂水县沂蒙山路中段",
                    Latitude = 35.783409,
                    Longitude = 118.642732

                },
                new ServiceProviderCoordinates
                {
                    Id = "2",
                    Title = "海川石化加油站（长安南路）",
                    Address = "山东省临沂市沂水县长安南路2号",
                    Latitude = 35.772018,
                    Longitude = 118.641547
                }
            };

            return list.ToArray();
        }
    }
}
