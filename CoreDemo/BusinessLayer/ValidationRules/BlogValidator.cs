using EntityLayer.Concrete;
using FluentValidation;


namespace BusinessLayer.ValidationRules
{
	public class BlogValidator : AbstractValidator<Blog>
	{
		public BlogValidator()
		{
			RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı zorunludur.")
				.MaximumLength(150).WithMessage("150 karakterden daha az veri girin.")
				.MinimumLength(5).WithMessage("En az 5 karakter girilmelidir.");

			RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği zorunludur.").MinimumLength(5).WithMessage("En az 5 karakter girin.");
			RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görseli zorunludur.");
		}
	}
}
