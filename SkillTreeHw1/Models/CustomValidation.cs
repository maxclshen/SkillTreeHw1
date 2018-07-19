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
                    string errMsg = $"輸入日期：{inputDate.ToShortDateString()}不得大於今天";
                    return new ValidationResult(errMsg);
                }

                return ValidationResult.Success;
            }

            return new ValidationResult("無輸入值");

        }
    }
}