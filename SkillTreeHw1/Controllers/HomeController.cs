using SkillTreeHw1.Models;
using SkillTreeHw1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace SkillTreeHw1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Categories"] = EnumHelper.GetSelectList(typeof(IncomeStatement));

            return View();
        }

        [ChildActionOnly]
        public ActionResult MoneyList()
        {
            var moneyList = MoneyListFactory.GetMoneyList();
            return View(moneyList);
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