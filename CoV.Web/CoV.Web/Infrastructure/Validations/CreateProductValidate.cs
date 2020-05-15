using CoV.Common.Resources;
using CoV.Service.DataModel;
using FluentValidation;

namespace CoV.Web.Infrastructure.Validations
{
    public class CreateProductValidate : AbstractValidator<ProductViewModel>
    {
        public CreateProductValidate()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue)
                .MinimumLength(1)
                .WithMessage(MessageResource.MinWord);
            
            RuleFor(x => x.Sku)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue)
                .MinimumLength(1)
                .WithMessage(MessageResource.MinWord);
            
            RuleFor(x => x.Details)
                .NotNull()
                .WithMessage(MessageResource.NotNullValue)
                .MinimumLength(1)
                .WithMessage(MessageResource.MinWord);
            
            
        }
    }
}