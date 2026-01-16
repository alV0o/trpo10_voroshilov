using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace trpo7_voroshilov_pr.Validators
{
    public class ValidationBirthday:ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                DateTime date = Convert.ToDateTime(value);

                if (date > DateTime.Now)
                {
                    return new ValidationResult(false, "Дата рождения не может быть больше сегодня!");
                }

                return ValidationResult.ValidResult;
            }
            catch
            {
                return new ValidationResult(false, "Неверная дата!");
            }

        }
    }
}
