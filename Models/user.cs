//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication19.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int id { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Required Field")]
        public string firstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Required Field")]
        public string lastName { get; set; }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Required Field")]
        public string gender { get; set; }
        [DisplayName("Age")]
        [Required(ErrorMessage = "Required Field")]
        public int age { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Required Field")]

        public string email { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "Required Field")]

        public string username { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password does not matched")]
        public string confirm_password { get; set; }
    }
}