using Chart.Mvc.ComplexChart;
using RedditSharp;
using redditview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redditview.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var webAgent = new BotWebAgent("goonthen111", "pikapika", "94Ywt31YswvTQg", "Cj02g5yCxmAMR0H6lAj96_ZEDDY", "https://github.com/pesin/front-end-misc");
            //This will check if the access token is about to expire before each request and automatically request a new one for you
            //"false" means that it will NOT load the logged in user profile so reddit.User will be null
            var reddit = new Reddit(webAgent, false);
            string name = "DOL8";
            var user = reddit.GetUser(name);
            UserInfo u = new UserInfo();
            u.CreatedDate = user.Created;
            u.Name = name;
          u.Comments=  user.Comments.OrderBy(rc=>rc.Created).Take(100).ToList().Select(rc =>
                new Comment()
                {
                    Date = rc.Created,
                    Text = rc.Body,
                    Score = rc.Score
                }).ToList();
          


          
            return View(u);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}