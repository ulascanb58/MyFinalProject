using BusinessLayer.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage(Messages.ProductNameInvalid);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage(Messages.ProductNameInvalid);
            RuleFor(p => p.UnitPrice).GreaterThan(1);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
       
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
