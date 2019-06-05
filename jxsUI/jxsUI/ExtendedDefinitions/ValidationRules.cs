using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Globalization;
namespace jxsUI.ExtendedDefinitions
{

    public class OnlyDigitsValidationRule : ValidationRule
    {
       // Regex regex;
        public OnlyDigitsValidationRule()
        {
           // regex = new Regex("[0-9.-]+"); //regex that matches disallowed text
        }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var validationResult = new ValidationResult(true, null);

            if (value != null)
            {
                              char[] chars = value.ToString().ToCharArray();

                for (int x = 0; x < chars.GetUpperBound(0); x++)
                {
                    if (!Char.IsDigit(chars[x]))
                    {
                        validationResult = new ValidationResult(false, "Illegal Characters, Please Enter Numeric Value");
                        break;
                    }
                }
                //if (!string.IsNullOrEmpty(value.ToString()))
                //{


                //    //var regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
                //    var parsingOk = regex.IsMatch(value.ToString());
                //    if (!parsingOk)
                //    {
                //        validationResult = new ValidationResult(false, "Illegal Characters, Please Enter Numeric Value");
                //    }
                //}
            }

            return validationResult;
        }
    }
}

