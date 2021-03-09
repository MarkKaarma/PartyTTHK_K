using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace PartyTTHK_K.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Your name")] 
        public string Name { get; set; }
        [Required(ErrorMessage = "Your email")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Error! Write correct email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Your phone")]
        [RegularExpression(@"\+372.+", ErrorMessage = "Error! In your phonenumber does not contain +372")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Wrooong")]
        public bool? WillAttend { get; set; }
    }
}