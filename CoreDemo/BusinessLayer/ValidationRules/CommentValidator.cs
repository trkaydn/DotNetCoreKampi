using EntityLayer.Concrete;
using FluentValidation;


namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.BlogID).NotEmpty().GreaterThan(0);
            RuleFor(x => x.CommentContent).NotEmpty();
            RuleFor(x => x.CommentMail).NotEmpty().EmailAddress();
            RuleFor(x => x.CommentUserName).NotEmpty().MinimumLength(2);
        }
    }
}
