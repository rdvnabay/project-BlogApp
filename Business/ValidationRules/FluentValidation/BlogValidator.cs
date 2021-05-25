using FluentValidation;
using YazilimBlogApp.Entities.Concrete;

namespace Business.ValidationRules.FluentValidation
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {

        }
    }
}
