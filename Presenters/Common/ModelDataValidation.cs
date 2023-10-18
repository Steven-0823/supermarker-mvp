using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Presenters.Common
{
    internal class ModelDataValidation
    {
        public void validate(object model)
        {
            string errorMenssage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model,validationContext, validationResults, true);
            if (isValid==false) 
            { 
            foreach (var item in validationResults)
                {
                    errorMenssage += item.ErrorMessage+ "\n";

                }
            throw new Exception(errorMenssage);
            }


        }

    }
}
