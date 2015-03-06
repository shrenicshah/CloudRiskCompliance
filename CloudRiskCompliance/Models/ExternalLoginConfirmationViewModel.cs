using System.ComponentModel.DataAnnotations;

namespace CloudRiskCompliance.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}