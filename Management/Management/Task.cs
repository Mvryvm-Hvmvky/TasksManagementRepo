//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string tStatus { get; set; }
        public string tDescription { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
        public int userID { get; set; }
    
        public virtual User User { get; set; }
    }
}
