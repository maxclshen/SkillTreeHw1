using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeHw1.Models.ViewModels
{
    public class AccountBookViewModel
    {
        public Category Category { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }

    public enum Category
    {

        收入 = 0,

        支出 = 1,
    }
}