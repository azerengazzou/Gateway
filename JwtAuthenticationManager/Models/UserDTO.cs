using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationManager.Models
{
    public class UserDTO
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identifiant { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime AddDate { get; set; }
    }
}
