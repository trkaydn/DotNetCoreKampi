using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
	public class RoleUpdateViewModel
	{

		public int Id { get; set; }

		[Required(ErrorMessage = "Lütfen rol adı giriniz.")]
		public string Name { get; set; }
	}
}
