using FluentValidation;

namespace DemoProjectAPI.Models
{
    public class PetValidator : AbstractValidator<PetAnimal>
    {
        public PetValidator() {
            RuleFor(x => x.petId).NotEmpty().WithMessage("Pet Id is required");
            RuleFor(x => x.petName).NotEmpty().WithMessage("Pet Name is required");
            RuleFor(x => x.petType).NotEmpty().WithMessage("Pet Type is required");
            RuleFor(x => x.gender).NotEmpty().WithMessage("Pet gender is required");
            RuleFor(x => x.IsVeg).NotEmpty().WithMessage("Pet Food is required");

        }
    }
}
