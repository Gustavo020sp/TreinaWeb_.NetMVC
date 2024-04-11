using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TreinaWeb.AspNetMvc.Web.Models 
{ 
	public class Person
	{
		[Required(ErrorMessage = "Name required")]
		[DisplayName("Type person name: ")]
		[MaxLength(20, ErrorMessage = "MAX 20 characters")]
		[MinLength(5, ErrorMessage = "MIN 5 characters")]
		public string Name { get; set; } = string.Empty;



		//[Required(ErrorMessage = "Age required")]
		[DisplayName("Type person age: ")]
		public int Age { get; set; }



		[Required(ErrorMessage = "Email required")]
		[DisplayName("Type person Address: ")]
		[MaxLength(20, ErrorMessage = "MAX 25 characters")]
		[MinLength(5, ErrorMessage = "MIN 5 characters")]
		public string Address { get; set; } = string.Empty;



		[Required(ErrorMessage = "Email required")]		
		[DisplayName("Type person Email: ")]
		[MaxLength(20, ErrorMessage = "MAX 20 characters")]
		[MinLength(5, ErrorMessage = "MIN 5 characters")]
		//[DataType(DataType.EmailAddress)]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;

        //public bool Active { get; set; }
    }
}
