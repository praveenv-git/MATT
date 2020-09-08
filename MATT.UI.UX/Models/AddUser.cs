using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MATT.UI.UX.Models
{
    public class AddUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string TelePhone { get; set; }

        public string Password { get; set; }

        public int InstitutionId { get; set; }

        public int Type { get; set; }
    }

    public class ChangePassword
    { 
       public int UserId { get; set; }

        public string Newpassword { get; set; }    
    }

    public class UsersList
    {
       public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Institution { get; set; }

        public string RoleName { get; set; }
    
    }



}