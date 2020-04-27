using CoV.Common.Resources;
using CoV.Service.DataModel;
using FluentValidation;

namespace CoV.Web.Infrastructure.Validations
{
    public class CustomerCreateValidation: AbstractValidator<CustomerViewModel>
    {
        public CustomerCreateValidation()
        {
             RuleFor(x => x.FirstName)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue)
                .MaximumLength(30)
                .WithMessage(MessageResource.MaxWord)
                .MinimumLength(1)
                .WithMessage(MessageResource.MinWord);


            RuleFor(x => x.LastName).NotNull()
                .WithMessage(MessageResource.NotNullValue)
                .MaximumLength(30)
                .WithMessage(MessageResource.MaxWord)
                .MinimumLength(1)
                .WithMessage(MessageResource.MinWord);


            RuleFor(x => x.PhoneNumber)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue)
                .MaximumLength(15)
                .WithMessage(MessageResource.MaxlengthNumber)
                .MinimumLength(9)
                .WithMessage(MessageResource.MinlengthNumber);

            RuleFor(x => x.Email).NotNull().WithMessage(MessageResource.NotNullValue)
                .NotEmpty()
                .WithMessage("Email address is required.")
                .EmailAddress()
                .WithMessage("A valid email address is required.");

            RuleFor(x => x.Address)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue)
                .MaximumLength(100)
                .WithMessage("Không nhâp quá 100 ký tự");


            RuleFor(x => x.City).NotNull().WithMessage(MessageResource.NotNullValue);

            RuleFor(x => x.PassWord).NotNull().WithMessage(MessageResource.NotNullValue)
                .MaximumLength(30)
                .WithMessage(MessageResource.MaxWord)
                .MinimumLength(1)
                .WithMessage(MessageResource.MinWord);
            
            RuleFor(x => x.ConfiguePassWord).NotNull().WithMessage(MessageResource.NotNullValue)
                .MaximumLength(30)
                .WithMessage(MessageResource.MaxWord)
                .MinimumLength(1)
                .WithMessage(MessageResource.MinWord);
        }
    }
}