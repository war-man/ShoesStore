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
            RuleFor(x => x.UserName).NotNull().WithMessage(MessageResource.UserNameNotNull);
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage(MessageResource.UserNameMaxLength);
                
            RuleFor(x => x.Password).NotNull().WithMessage(MessageResource.PassWorkNotNull);
            RuleFor(x => x.Password).MinimumLength(3).WithMessage(MessageResource.PasswordMinLength);
        }
    }
}