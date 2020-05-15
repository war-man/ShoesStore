using CoV.Common.Resources;
using CoV.Service.DataModel;
using FluentValidation;

namespace CoV.Web.Infrastructure.Validations
{
    /// <summary>
    /// Check Validattion User View Model Create Or Update 
    /// </summary>
    public class UserViewValidation : AbstractValidator<UserViewModel>
    {
        public UserViewValidation()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage(MessageResource.NotNullValue);
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage(MessageResource.MinimumLengthValidator);
                
            RuleFor(x => x.Password).NotNull().WithMessage(MessageResource.NotNullValue);
            RuleFor(x => x.Password).MinimumLength(5).WithMessage(MessageResource.PasswordMinLength);
        }
    }
}