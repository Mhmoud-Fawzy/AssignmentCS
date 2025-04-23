using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models.Identity
{
	public class SignInViewModel
	{
		[EmailAddress]
		public string Email { get; set; } = null!;

		[DataType(DataType.Password)]
		public string Password { get; set; } = null!;

		public bool RememberMe { get; set; }   // To know which to delete Token from Cookie storage or remember the user and let the Token

	}
}
