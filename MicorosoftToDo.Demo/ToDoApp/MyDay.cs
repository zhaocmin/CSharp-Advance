//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class MyDay
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string MyDayText { get; set; }
    
        public virtual User User { get; set; }
    }
}
