//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project113_G3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class UserData
    {
        public int UID { get; set; }
        public string Name { get; set; }
        public string Email_User { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "B_Date")]
        public Nullable<System.DateTime> Bd_User { get; set; }
        public string GenderUser { get; set; }
        public string Description { get; set; }
        public string User_Id { get; set; }
        public string url { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
