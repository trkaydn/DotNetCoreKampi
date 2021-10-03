using EntityLayer.Concrete;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar ismi zorunludur.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-Posta zorunludur.").EmailAddress();
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("İsim en az 2 karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.WriterPasswordConfirm).NotEmpty().WithMessage("Şifre tekrarı boş geçilemez.");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.")
                .Must(IsPasswordValid).WithMessage("regex error")
                .Equal(x => x.WriterPasswordConfirm).WithMessage("Girilen şifreler uyuşmuyor.");

        }

        private bool IsPasswordValid(string arg)
        {
            if (string.IsNullOrEmpty(arg))
                return false;

            Regex regex = new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).+");
            return regex.IsMatch(arg);
        }

    }
}
