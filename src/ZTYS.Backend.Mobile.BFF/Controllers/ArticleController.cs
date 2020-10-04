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
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;

        public ArticleController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Article> Get(string category, int pageSize, int page)
        {
            var list = new List<Article>()
            {
                new Article
                {
                    Id = "1",
                    Title = "全县交通运输系统安全生产专项整治三年行动动员会议召开",
                    Url = "https://mp.weixin.qq.com/s/wqC2dMIf9gak8qSRmbtDuA",
                    TitleImageUrl = "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3tRIWzVR62op7NFID4PfkEUQHGCLibyaa1PlPv8e7ZUaFTOo9yBRujxJQicdx71fEyLibcsKlmhaJEsA/640?wx_fmt=jpeg",
                    DatePublished = new DateTime(2020,9,21)
                },
                new Article
                {
                    Id = "2",
                    Title = "今天起四部门联合对城区交通违法行为进行集中整治",
                    Url = "https://mp.weixin.qq.com/s/KBRVk1z0_yFUONRjYNwTQw",
                    TitleImageUrl = "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3tRIWzVR62op7NFID4PfkEUCrjicicbly30jDxGVWQcYTcoH9tbDIe3pJUDTQNW6kiaMnex7FPOcNMOA/640?wx_fmt=jpeg",
                    DatePublished = new DateTime(2020,9,21)
                },
                new Article
                {
                    Id = "3",
                    Title= "征求意见！《道路运输危险货物车辆标志》",
                    Url= "https://mp.weixin.qq.com/s/KBRVk1z0_yFUONRjYNwTQw",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3tRIWzVR62op7NFID4PfkEUr8OaqE1D4YAHl6icgpDjr3mnrQzicIiazshOqr5z0Kdh0VLaFqLTIdjhg/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 21)
                 },
                new Article
                {
                    Id = "4",
                    Title= "县交通运输局机关党支部党员结合“双报到”活动开展文明交通安全出行宣传",
                    Url= "https://mp.weixin.qq.com/s/vEmmbTsAMsnt6UkH5HHszQ",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3vicdticmXhAYKllaGnIfjiaBcBlkXRicNvHFRtcWrv1BFiaicAtEJ1nOLTnVMCR9cSsoj72NCicBriaLkGFw/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 18)
                 },
                new Article
                {
                    Id = "5",
                    Title= "致全县广大交通运输从业者的一封信",
                    Url= "https://mp.weixin.qq.com/s/FQQ0UlP3YsPNeavhYfhSvA",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3vicdticmXhAYKllaGnIfjiaBc97OnNvaVLrOxc7CRTLfic7iafaXQXPusibzAKLR8t8h94Pfs6EAG29Y8g/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 18)
                 },
                new Article
                {
                    Id = "6",
                    Title= "县交通运输局开展信访法规“五个一”集中宣传活动",
                    Url= "https://mp.weixin.qq.com/s/3zr_E2eB1rJJIbmmhYXzdg",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3uwbGJPLN6IvXiao2b3fPbXmUl5XaZN7icibRlExJmeoSxL8z8gyKCDCuNxEUyRrpkibcibXG8s2Qyn8Mw/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 17)
                 },
                new Article
                {
                    Id = "7",
                    Title= "这次部务会对做好科技创新、优化营商环境做了部署",
                    Url= "https://mp.weixin.qq.com/s/SnUgn6jRYOHPFae7OwD3QA",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3uwbGJPLN6IvXiao2b3fPbXmgCWDXLk9icFITl6xlGZxKzZfntlrxsjWgpdPEPvgVI24Aicib4GsRz5Rw/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 17)
                 },
                new Article
                {
                    Id = "8",
                    Title= "四十里堡镇中小学校教师的“定制公交”",
                    Url= "https://mp.weixin.qq.com/s/qCcnDZBP6GUtYfHzQkr0nA",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3urUibS7qhILhvpChU4SiceHFFLsD0XwpdfnN0BkicdmcsfXWwiaiaXVXPjlB665NvTLiaZWQCOkdNFs2Aw/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 16)
                },
                new Article
                {
                    Id = "9",
                    Title= "【访谈】全面推行行政执法“三项制度” 进一步推进严格规范公正文明执法",
                    Url= "https://mp.weixin.qq.com/s/ifEbU2-PLeFR2ixO50WjrQ",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3urUibS7qhILhvpChU4SiceHFRTuBXnsAyoibOE44SxRSpDBPddmtpr0CjIibZSkko6wVrSibHqZ4y2cHQ/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 16)
                },
                new Article
                {
                    Id = "10",
                    Title= "省交通运输厅来我县现场审核全国城乡交通运输一体化示范县创建工作",
                    Url= "https://mp.weixin.qq.com/s/EcV9oRzEBs-VIVuhBmByng",
                    TitleImageUrl= "http://mmbiz.qpic.cn/mmbiz_jpg/Gsov4eSyD3sxHTDCYP1hDUZC2G8onSe715XrTIwtia5YwmYCYAr42QSOpllB3BqUia65EEcl33s710rx5lccV11Q/640?wx_fmt=jpeg",
                    DatePublished= new DateTime(2020, 9, 15)
                }
            };

            return list.ToArray();
        }
    }
}
