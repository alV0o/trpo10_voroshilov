using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace trpo7_voroshilov_pr.Validators
{
    public class ValidationPhone:ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value.ToString();
            if (string.IsNullOrEmpty(input))
            {
                return new ValidationResult(false, "Ввод обязателен!");
            }
            if (input.Length != 11)
            {
                return new ValidationResult(false, "Длина 11 символов!");
            }
            if (input[0] != '8')
            {
                return new ValidationResult(false, "Первая цифра должна быть = 8");
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsDigit(input[i]))
                {
                    return new ValidationResult(false, "Телефон должен содержать только цифры!");
                }
            }

            return ValidationResult.ValidResult;
        }
    }
}
