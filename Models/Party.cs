using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace PartyTTHK_K.Models
{
    public class Party
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Write name party")]
        public string Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PartyDate { get; set; }
        public bool? WillAttend { get; set; }
    }
}