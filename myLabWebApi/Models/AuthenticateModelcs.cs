using System.ComponentModel.DataAnnotations;

namespace myLabWebApi.Models
{
    public class AuthenticateModelcs
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}