using FinalProjectCsharp.Model;
using FluentValidation;

namespace FinalMVC.Models
{
    public class Validation : AbstractValidator<Patient>
    {
        public Validation()
        {
            RuleFor(x => x.pId).NotEmpty().WithMessage("Patient Id is required");
            RuleFor(x => x.pName).NotEmpty().WithMessage("Patient Name is required");
            RuleFor(x => x.appDate).NotEmpty().WithMessage("Patient Name is required");
            RuleFor(x => x.pMobile).NotEmpty().WithMessage("Patient Name is required").MinimumLength(10).WithMessage("Mobile Number must be at least 10 characters.")
;
            RuleFor(x => x.pDisease).NotEmpty().WithMessage("Patient Name is required");
        }
    }
}
