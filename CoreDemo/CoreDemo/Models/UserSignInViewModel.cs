using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
		[Display(Name = "Kullanıcı Adı")]
		[Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
		public string UserName { get; set; }


		[Display(Name = "Şifre")]
		[Required(ErrorMessage = "Lütfen şifre giriniz.")]
		public string Password { get; set; }
	}
}
