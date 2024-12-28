using FluentValidation;

namespace FinalProjectCsharp.Model
{
    public class PatientValidation : AbstractValidator<Patient>
    {
        public PatientValidation()
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
