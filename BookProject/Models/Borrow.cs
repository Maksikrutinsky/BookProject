//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrow
    {
        public int BorrowwId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public Nullable<bool> BorrowStatus { get; set; }
        public Nullable<System.DateTime> BorrowDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}