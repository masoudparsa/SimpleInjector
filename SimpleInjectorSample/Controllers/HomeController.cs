using Business;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleInjectorSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            BPerson personBusiness =(BPerson) SimpleInjector.SimpleInjectorContainer.GetInstance<BPerson>();
            BUser userBusiness = (BUser)SimpleInjector.SimpleInjectorContainer.GetInstance<BUser>();
            Person personObj = personBusiness.SearchPerson(1);
          
            Model.User userObj = userBusiness.SearchUser(1);
            return View();
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