using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZTYS.Backend.Mobile.BFF.Models
{
    public class Article
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string TitleImageUrl { get; set; } 

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
