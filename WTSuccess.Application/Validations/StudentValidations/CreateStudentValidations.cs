using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Requests.StudentRequests;

namespace WTSuccess.Application.Validations.StudentValidations
{
    public class CreateStudentValidations : AbstractValidator<CreateStudentRequestModel>
    {
        public CreateStudentValidations()
        {
            RuleFor(s=>s.Name).NotEmpty().NotNull();
            RuleFor(s=>s.Surname).NotEmpty().NotNull();
            RuleFor(s=>s.Email).EmailAddress().NotEmpty().NotNull();
        }
    }
}
