using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace trpo7_voroshilov_pr.Validators
{
    public class ValidationFIO:ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value.ToString();
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]))
                {
                    return new ValidationResult(false, "ФИО не должно содержать цифр!");
                }
            }

            return ValidationResult.ValidResult;
        }
    }
}
