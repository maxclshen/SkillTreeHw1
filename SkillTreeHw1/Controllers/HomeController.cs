using SkillTreeHw1.Models;
using SkillTreeHw1.Models.ViewModels;
using SkillTreeHw1.Repository;
using SkillTreeHw1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTreeHw1.Controllers
{
    public class HomeController : Controller
    {

        private readonly AccountBookService _accountbookService;
        private readonly UnitOfWork _unitOfWork;

        public HomeController()
        {
            _unitOfWork = new UnitOfWork();
            _accountbookService = new AccountBookService(_unitOfWork);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AccountBook data)
        {
            if (ModelState.IsValid)
            {
                //data.Id = new Guid(); guid 會是 00000000-0000-0000-0000-000000000000
                data.Id = Guid.NewGuid(); //正確
                _accountbookService.Add(data);
                _unitOfWork.Commit();
            }
            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public ActionResult AccountBookList()
        {
            //List<AccountBookViewModel> moneyList = MoneyListFactory.GetMoneyList();
            var source = _accountbookService.GetAll().Take(50);
            return View(source);
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