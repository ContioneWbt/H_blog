using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H_Blog.Models.Music;

namespace H_Blog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetMusicList()
        {
            List<MusicModel> musiclist = new List<MusicModel>()
            {
                new MusicModel { title = "Wishing", url = "/Content/APlayer/music/浪子康.mp3", pic = "/Content/images/Absolutely.jpg", author = "水瀬いのり" },
                new MusicModel { title = "Stay Alive", url = "/Content/APlayer/music/乌龟组合.mp3", pic = "/Content/images/Absolutely.jpg", author = "高橋李依" },
                new MusicModel { title = "遇见", url = "http://music.163.com/song/media/outer/url?id=287035.mp3", pic = "http://y.gtimg.cn/music/photo_new/T002R300x300M000002ehzTm0TxXC2.jpg", author = "孙燕姿" }
            };
            //[new Random().Next(3)]
            return Json(musiclist, JsonRequestBehavior.AllowGet);
        }
    }
}