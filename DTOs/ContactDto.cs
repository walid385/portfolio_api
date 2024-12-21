using System.ComponentModel.DataAnnotations;

namespace Portfolio.API.DTOs
{
    public class ContactUsDto
    {
        [Required (ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Invalid E-Mail Adress, please enter a valid E-Mail Adress")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
} 