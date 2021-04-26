
using LogWebApi.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   
            return View();
        }
        public ActionResult DavetForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DavetForm(DavetiyeModel model)
        {
            
            if (ModelState.IsValid)
            {
                // System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(true);// konum bilgisini çeker
                LLog.logger.Info(model.Ad);
                
            }
            else
            {
                LLog.logger.Info("Alanlar Gelmedi");
                
            }

            return View("Thanks", model);
        }
    }
}
