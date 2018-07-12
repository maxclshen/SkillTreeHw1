using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillTreeHw1.Models.ViewModels;

namespace SkillTreeHw1.Models
{
    public class MoneyListFactory
    {
        public static List<MoneyViewModel> GetMoneyList()
        {
            Random gen = new Random((int)DateTime.Now.Ticks);
            int CgRange = 2;
            int AmtRange = 10000;
            int DateRange = 365;
            List<MoneyViewModel> moneyList = new List<MoneyViewModel>();
            for (int i = 0; i < 50; i++)
            {
                moneyList.Add(new MoneyViewModel()
                {
                    Category = gen.Next(CgRange) == 1 ? IncomeStatement.支出 : IncomeStatement.收入,
                    Amount = gen.Next(AmtRange),
                    Date = DateTime.Today.AddDays(gen.Next(DateRange))
                });
            }
            return moneyList;
        }
    }
}