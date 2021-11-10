using AwesomeApi.Handlers.Commands;
using FluentValidation;

namespace AwesomeApi.Validation
{
    public class SaveUserValidator : AbstractValidator<SaveUserCommand>
    {
        public SaveUserValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty();
            
            RuleFor(x => x.Password)
                .NotEmpty();
        }
    }
}