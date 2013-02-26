using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cadtrak.Models;

namespace Cadtrak.Areas.ViewModels
{
    public class MembersViewModel
    {
        public int id { get; set; }
        public int Admin { get; set; }
        public int Active { get; set; }
        public int AcceptedTerms { get; set; }
        public IEnumerable<ServiceInformation> Status { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Nickname")]
        public string Nickname { get; set; }
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Display(Name = "Comments")]
        public string Comments { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastLogin { get; set; }
    }
}