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
    public class CheckUpdateController : ControllerBase
    {
        private readonly ILogger<CheckUpdateController> _logger;

        public CheckUpdateController(ILogger<CheckUpdateController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        [HttpGet]
        public AppVersion Get(int versionCode, string versionName, string platformType)
        {
            var newAppVersion = new AppVersion
            {
                Id = "1",
                VersionCode = 130,
                VersionName = "1.6.1",
                UpdateDigest = "测试",
                ForcedUpdate = true,
                PackageDownloadUrl = "http://www.zhangtongyishui.com"
            };

            return newAppVersion;
        }
    }
}
