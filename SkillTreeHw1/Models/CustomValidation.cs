using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillTreeHw1.Models
{
    public sealed class CantGreaterThanToday : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime inputDate = Convert.ToDateTime(value);
                if (inputDate > DateTime.Now)
                {
                    return new ValidationResult($"輸入日期：{inputDate.ToShortDateString()}不得大於今天");
                }
            }
            return ValidationResult.Success;
        }
    }
}