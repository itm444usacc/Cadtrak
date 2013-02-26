using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Security;
using Cadtrak.Models;

namespace Cadtrak.Areas.SecurityGuard.Models
{
    public class UserViewModel
    {
        public MembershipUser User { get; set; }
        public bool RequiresSecretQuestionAndAnswer { get; set; }
        public string[] Roles { get; set; }
    }
}
