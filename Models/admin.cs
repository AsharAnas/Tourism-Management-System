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

    public partial class admin
    {
        public int id { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "Required Field")]
        public string name { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
