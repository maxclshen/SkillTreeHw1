using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeHw1.Models.ViewModels
{
    public class MoneyViewModel
    {
        public IncomeStatement Category { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }

    public enum IncomeStatement
    {

        收入,

        支出,
    }
}