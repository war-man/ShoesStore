using CoV.Common.Resources;
using CoV.Service.DataModel;
using FluentValidation;

namespace CoV.Web.Infrastructure.Validations
{
    public class LoginAccountValidate : AbstractValidator<LoginForgetPassword>
    {
        public LoginAccountValidate()
        {
            RuleFor(x => x.Username).NotNull().WithMessage(MessageResource.NotNullValue);
            RuleFor(x => x.Username).MaximumLength(35).WithMessage(MessageResource.UserNameMaxLength);
            
            RuleFor(x => x.Password).NotNull().WithMessage(MessageResource.NotNullValue);
            RuleFor(x => x.Password).MinimumLength(5).WithMessage(MessageResource.PasswordMinLength);
            
            RuleFor(x => x.PasswordNew).NotNull().WithMessage(MessageResource.NotNullValue);
            RuleFor(x => x.PasswordNew).MinimumLength(5).WithMessage(MessageResource.PasswordMinLength);

            RuleFor(x => x.PasswordNewConfigure).NotNull().WithMessage(MessageResource.NotNullValue);
            RuleFor(x => x.PasswordNewConfigure).MinimumLength(5).WithMessage(MessageResource.PasswordMinLength);
        }
    }
}