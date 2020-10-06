using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZTYS.Backend.Mobile.BFF.Models
{
    public class AppVersion
    {
        public string Id { get; set; }

        /// <summary>
        /// 采用持续增加的整数，如以日期+三位数字的方式
        /// 如：20201006001
        /// </summary>
        public int VersionCode { get; set; }
        public string VersionName { get; set; }

        /// <summary>
        /// iOS,Android等
        /// </summary>
        public string PlatformType { get; set; }
        public string UpdateDigest { get; set; }

        /// <summary>
        /// 是否强制升级
        /// </summary>
        public bool ForcedUpdate { get; set; }

        /// <summary>
        /// 更新包下载地址
        /// </summary>
        public string PackageDownloadUrl { get; set; }
        public DateTime DatePublished { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        /// <summary>
        /// 数据行状态
        /// </summary>
        public bool RowStatus { get; set; }
        /// <summary>
        /// 行版本的跟踪属性
        /// https://docs.microsoft.com/zh-cn/aspnet/core/data/ef-rp/concurrency?view=aspnetcore-3.1&tabs=visual-studio#add-a-tracking-property
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
