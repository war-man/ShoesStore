using CoV.Common.Resources;
using CoV.Service.DataModel;
using FluentValidation;

namespace CoV.Web.Infrastructure.Validations
{
    /// <summary>
    /// Check Validate login Model 
    /// </summary>
    public class LoginValidation : AbstractValidator<LoginModel>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Username).NotNull().WithMessage(MessageResource.UserNameNotNull);
            RuleFor(x => x.Username).MaximumLength(35).WithMessage(MessageResource.UserNameMaxLength);
                
            RuleFor(x => x.Password).NotNull().WithMessage(MessageResource.PassWorkNotNull);
            RuleFor(x => x.Password).MinimumLength(3).WithMessage(MessageResource.PasswordMinLength);

        }
    }
}