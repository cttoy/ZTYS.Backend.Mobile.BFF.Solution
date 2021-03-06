﻿using System;
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
            //JSON中的换行符 \n 需要转义为 \\n
            //换行符后面要紧接内容
            var newVersionCode = 110;

            if (versionCode < newVersionCode)
            {
                var newAppVersion = new AppVersion
                {
                    Id = "1",
                    VersionCode = newVersionCode,
                    VersionName = "1.0.10",
                    UpdateDigest = "1.增加出租叫车过渡窗口\\n2.安卓下立即叫车可直接拨号",
                    ForcedUpdate = false,
                    PackageDownloadUrl = "https://ysxjtysj.oss-cn-beijing.aliyuncs.com/ztys/ztys-1.0.10.apk"
                };

                return newAppVersion;
            }

            return null;
        }
    }
}
