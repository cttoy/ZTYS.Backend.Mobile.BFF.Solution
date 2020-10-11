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
            var list = new List<ServiceProviderCoordinates>();

            if (!string.IsNullOrWhiteSpace(serviceType))
            {
                switch (serviceType.ToLower())
                {
                    case "gas":
                        list = new List<ServiceProviderCoordinates>()
                        {
                            new ServiceProviderCoordinates
                            {
                                Id = "1",
                                Title = "中国石化（沂水第82加油站）",
                                Address = "山东省临沂市沂水县沂蒙山路中段",
                                Longitude = Bd2Gd(118.642732, 35.783409).Item1,
                                Latitude = Bd2Gd(118.642732, 35.783409).Item2

                            },
                            new ServiceProviderCoordinates
                            {
                                Id = "2",
                                Title = "海川石化加油站（长安南路）",
                                Address = "山东省临沂市沂水县长安南路2号",
                                Longitude = Bd2Gd(118.641547, 35.772018).Item1,
                                Latitude = Bd2Gd(118.641547, 35.772018).Item2
                            }
                        };
                        break;
                    case "repair":
                        list = new List<ServiceProviderCoordinates>()
                        {
                            new ServiceProviderCoordinates
                            {
                                //118.640556,35.765415
                                Id = "1",
                                Title = "沂水兴保汽车维修有限公司",
                                Address = "山东省临沂市沂水县长安南路20号",                                
                                Longitude = Bd2Gd(118.640556, 35.765415).Item1,
                                Latitude = Bd2Gd(118.640556, 35.765415).Item2,

                            },
                            new ServiceProviderCoordinates
                            {
                                //118.642425,35.760538
                                Id = "2",
                                Title = "沂水万胜汽车修理厂",
                                Address = "临沂市沂水县腾飞路与长安南路交叉路口往东约200米(鲁商城市广场北侧约50米)",
                                Longitude = Bd2Gd(118.642425, 35.760538).Item1,
                                Latitude = Bd2Gd(118.642425, 35.760538).Item2
                            }
                        };
                        break;
                    default:
                        break;
                }
            }

            return list.ToArray();
        }           
    
        /// <summary>
        /// 百度坐标转换为高德/腾讯坐标
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        private (double, double) Bd2Gd(double longitude, double latitude)
        {
            double pi = 3.14159265358979324 * 3000.0 / 180.0;
            double x = longitude - 0.0065;
            double y = latitude - 0.006;
            double z = Math.Sqrt(x * x + y * y) - 0.00002 * Math.Sin(y * pi);
            double theta = Math.Atan2(y, x) - 0.000003 * Math.Cos(x * pi);
            double outLongitude = z * Math.Cos(theta);
            double outLatitude = z * Math.Sin(theta);

            return (outLongitude, outLatitude);
        }

        /// <summary>
        /// 高德/腾讯坐标转换为百度坐标
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        private (double, double) Gd2Bd(double longitude, double latitude)
        {
            double pi = 3.14159265358979324 * 3000.0 / 180.0;
            double x = longitude;
            double y = latitude;
            double z = Math.Sqrt(x * x + y * y) - 0.00002 * Math.Sin(y * pi);
            double theta = Math.Atan2(y, x) - 0.000003 * Math.Cos(x * pi);
            double outLongitude = z * Math.Cos(theta) + 0.0065;
            double outLatitude = z * Math.Sin(theta) + 0.006;

            return (outLongitude, outLatitude);
        }
    }
}
