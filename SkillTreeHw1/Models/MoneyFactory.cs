using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillTreeHw1.Models.ViewModels;

namespace SkillTreeHw1.Models
{
    public class MoneyListFactory
    {
        public static IEnumerable<MoneyViewModel> GetMoneyList()
        {
            Random gen       = new Random((int) DateTime.Now.Ticks);
            int    cgRange   = 2;
            int    amtRange  = 10000;
            int    dateRange = 365;
            for (int i = 0; i < 50; i++)
            {
                yield return new MoneyViewModel()
                {
                    Category = gen.Next(cgRange) == 1 ? IncomeStatement.支出 : IncomeStatement.收入,
                    Amount   = gen.Next(amtRange),
                    Date     = DateTime.Today.AddDays(gen.Next(dateRange))
                };
            }
        }
    }
}