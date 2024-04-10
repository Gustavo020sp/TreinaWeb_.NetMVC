using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TreinaWeb.AspNetMvc.Web.Models 
{ 
	public class Person
	{
		[Required(ErrorMessage = "Name required")]
		[DisplayName("Type person name: ")]
		public string Name { get; set; } = string.Empty;



		//[Required(ErrorMessage = "Age required")]
		[DisplayName("Type person age: ")]
		public int Age { get; set; }



		[Required(ErrorMessage = "Email required")]
		[DisplayName("Type person Address: ")]
		public string Address { get; set; } = string.Empty;



		[Required(ErrorMessage = "Email required")]
		[DisplayName("Type person Email: ")]
		public string Email { get; set; } = string.Empty;
    }
}
