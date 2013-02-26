using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Security;
using MVC3Test.Models;

namespace MVC3Test.Areas.SecurityGuard.Models
{
    public class UserViewModel
    {
        public MembershipUser User { get; set; }
        public bool RequiresSecretQuestionAndAnswer { get; set; }
        public string[] Roles { get; set; }
    }
}
