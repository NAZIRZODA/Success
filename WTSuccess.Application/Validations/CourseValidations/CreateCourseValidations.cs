using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Requests.CourseRequests;

namespace WTSuccess.Application.Validations.CourseValidations
{
    public class CreateCourseValidations : AbstractValidator<CreateCourseRequestModel>
    {
        public CreateCourseValidations()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.Chapters).NotNull().NotEmpty();
        }
    }
}
