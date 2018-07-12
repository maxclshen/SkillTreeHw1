using SkillTreeHw1.Models;
using SkillTreeHw1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTreeHw1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> CategoryList = new List<SelectListItem>();
            foreach (IncomeStatement state in Enum.GetValues(typeof(IncomeStatement)))
            {
                CategoryList.Add(new SelectListItem()
                {
                    Text = state.ToString(),
                    Value = state.ToString(),
                });
            }

            ViewData["Categories"] = CategoryList;

            return View();
        }

        [ChildActionOnly]
        public ActionResult MoneyList()
        {
            List<MoneyViewModel> moneyList = MoneyListFactory.GetMoneyList();
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