using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;
using WebApplication15.Controllers;

namespace WebApplication15.Filters
{
    public class ReauestLoggerAttribute : FilterAttribute, IActionFilter
    {

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HomeController));  //Declaring Log4Net


            Database.SetInitializer<LoggerContext>(new DropCreateDatabaseIfModelChanges<LoggerContext>());
            ReauesDetail reauesDetail = new ReauesDetail()
            {
                Requesttime = filterContext.HttpContext.Request.TimedOutToken.ToString(),
                RequestURI = filterContext.HttpContext.Request.Url.ToString(),
                Querystring = filterContext.HttpContext.Handler.ToString(),
                StatusCode = filterContext.HttpContext.Response.StatusCode.ToString()
            };

            using (LoggerContext db = new LoggerContext())
            {
                db.ReauesDetails.Add(reauesDetail);
                db.SaveChanges();
                logger.Info(reauesDetail);
            }

            filterContext.ExceptionHandled = true;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //throw new NotImplementedException();
        }
    }
}