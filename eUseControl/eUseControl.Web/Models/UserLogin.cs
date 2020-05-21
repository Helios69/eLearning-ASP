using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class UserLogin
    {
        public static bool Status { get; set; }
        public string Credential { get; set; }
        public string Password { get; set; }
    }
}