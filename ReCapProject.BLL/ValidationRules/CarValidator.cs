using System;
using FluentValidation;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.BLL.ValidationRules
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(0);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2015).When(c => c.BrandId == 3);
            RuleFor(c => c.Name).Must(StartWithUpperCase);
        }

        private bool StartWithUpperCase(string arg)
        {
            var result = arg.Substring(0, 1);  
            return result.ToUpper() == result;
        }
    }
}
