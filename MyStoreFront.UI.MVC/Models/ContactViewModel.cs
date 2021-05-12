using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyStoreFront.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Name is required.")]
        [Display(Name = "Your Name")]
        public string Name { get; set; }
        public string Subject { get; set; }

        [Required(ErrorMessage = "* Message is required.")]
        [UIHint("Multiline Text")]
        public string Message { get; set; }
        [Required(ErrorMessage = "* Email address is required.")]
        [EmailAddress(ErrorMessage = "* Email is formatted incorrectly.")]
        [Display(Name = "Your Email")]
        public string EmailAddress { get; set; }
    }
}