using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class MailModel
    {
        [Required(ErrorMessage = "Please enter the receiver")]
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}