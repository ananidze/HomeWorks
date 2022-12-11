using FluentValidation;
using Homework_8.Models;

namespace Homework_8.Validators;

public class PersonValidator: AbstractValidator < Person > {
    public PersonValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");
        RuleFor(x => x.PersonAddress.City).NotEmpty().WithMessage("City is required");
        RuleFor(x => x.WorkExperience).NotEmpty().WithMessage("WorkExperience is required");
        RuleFor(x => x.PersonAddress.Country).NotEmpty().WithMessage("Country is required");
        RuleFor(x => x.PersonAddress.HomeNumber).NotEmpty().WithMessage("HomeNumber is required");
        RuleFor(x => x.CreateDate).NotEmpty().WithMessage("CreateDate is required").LessThan(DateTime.Now);
        RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is required").Length(0, 50).WithMessage("LastName must be less than 50 characters");
        RuleFor(x => x.Salary).NotEmpty().WithMessage("Salary is required").InclusiveBetween(0, 10000).WithMessage("Salary must be between 0 and 10000");
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName is required").Length(0, 50).WithMessage("FirstName must be less than 50 characters");
        RuleFor(x => x.JobPosition).NotEmpty().WithMessage("JobPosition is required").Length(0, 50).WithMessage("JobPosition must be less than 50 characters");
    }
}
