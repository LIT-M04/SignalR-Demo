using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;

namespace MvcApplication36.Controllers
{


    public class HomeController : Controller
    {
        //static HomeController()
        //{
        //    Random rnd = new Random();
        //    var th = new Thread(w =>
        //    {
        //        while (true)
        //        {
        //            Thread.Sleep(rnd.Next(500, 1000));
        //            var context = GlobalHost.ConnectionManager.GetHubContext<SimpleHub>();
        //            context.Clients.All.newMessageReceived(rnd.Next(1, 1928682736));
        //        }
        //    });
        //    th.Start();
        //}

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Message(string message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<SimpleHub>();
            context.Clients.All.newMessageReceived(new { time = DateTime.Now.ToLongTimeString(), message = message });
        }
    }
}
