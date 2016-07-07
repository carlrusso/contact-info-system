using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SignInSystem.Models
{
    public class Attendee
    {
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Email Address Required")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Confirm Password")]
        [Compare("Email", ErrorMessage ="Email address does not match")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage ="Phone Number Required")]
        [DataType(DataType.PhoneNumber, ErrorMessage ="Invalid Phone Number")]
        public string PhoneNumber { get; set; }

    }
}