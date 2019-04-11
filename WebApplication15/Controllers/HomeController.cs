using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Filters;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HomeController));  //Declaring Log4Net

        [ReauestLoggerAttribute]
        public ActionResult Index()
        {

            return View();
        }

        [ReauestLoggerAttribute]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ExceptionLogger]
        public ActionResult Contact()
        {
            try
            {
                int x, y, z;
                x = 5; y = 0;
                z = x / y;
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
            return View();
        }
    }
}