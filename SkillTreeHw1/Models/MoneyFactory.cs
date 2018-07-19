using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillTreeHw1.Models.ViewModels;

namespace SkillTreeHw1.Models
{
    public class MoneyListFactory
    {
        public static IEnumerable<AccountBookViewModel> GetMoneyList()
        {
            Random gen      = new Random((int)DateTime.Now.Ticks);
            int cgRange     = 2;
            int amtRange    = 10000;
            int dateRange   = 365;
            //List<AccountBookViewModel> moneyList = new List<AccountBookViewModel>();
            for (int i = 0; i < 50; i++)
            {
                yield return new AccountBookViewModel()
                {
                    Category = gen.Next(cgRange) == 1 ? Category.支出 : Category.收入,
                    Amount   = gen.Next(amtRange),
                    Date     = DateTime.Today.AddDays(gen.Next(dateRange))
                };
            }
            //return moneyList;
        }
    }
}