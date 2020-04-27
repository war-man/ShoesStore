using CoV.Common.Resources;
using CoV.Service.DataModel;
using FluentValidation;

namespace CoV.Web.Infrastructure.Validations
{
    public class CustomerLoginValidation : AbstractValidator<loginCustomerViewModel>
    {
        public CustomerLoginValidation()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue);
            RuleFor(x => x.PassWord)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue);
        }
    }
}