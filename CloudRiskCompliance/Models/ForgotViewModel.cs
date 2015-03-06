﻿using System.ComponentModel.DataAnnotations;

namespace CloudRiskCompliance.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}