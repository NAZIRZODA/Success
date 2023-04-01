using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Requests.ChapterRequests;

namespace WTSuccess.Application.Validations.ChapterValidations
{
    public class CreateChapterValidation : AbstractValidator<CreateChapterRequestModel>
    {
        public CreateChapterValidation()
        {
            RuleFor(chap => chap.Name).NotNull().NotEmpty();
            RuleFor(chap => chap.Students).NotEmpty().NotNull();
        }
    }
}
