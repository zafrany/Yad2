using System.ComponentModel.DataAnnotations;

namespace Yad2.Models
{
    public class Contact
    {
        [Required]
        public string ContactName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }


    }
}
