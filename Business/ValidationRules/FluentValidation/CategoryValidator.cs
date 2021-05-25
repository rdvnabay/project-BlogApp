using FluentValidation;
using YazilimBlogApp.Entities.Concrete;

namespace Business.ValidationRules.FluentValidation
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {

        }
    }
}
