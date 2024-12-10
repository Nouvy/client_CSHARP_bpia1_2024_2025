using System;
namespace BPIA1_avec_menu
{
	public class LoginResponse
	{
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public User User { get; set; }
        public string Status { get; set; }
    }
}

