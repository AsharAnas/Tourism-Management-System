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
    
    public partial class package
    {
        public package()
        {
            this.register1 = new HashSet<register1>();
        }
    
        public int id { get; set; }
        public string packages { get; set; }
    
        public virtual ICollection<register1> register1 { get; set; }
    }
}