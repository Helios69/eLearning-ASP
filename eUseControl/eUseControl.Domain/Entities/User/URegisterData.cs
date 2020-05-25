using System;
using System.Collections.Generic;
using System.Text;

namespace eUseControl.Domain.Entites.User
{
    public class URegisterData
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
    }
}