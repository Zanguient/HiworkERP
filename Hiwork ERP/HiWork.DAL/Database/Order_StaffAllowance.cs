//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiWork.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_StaffAllowance
    {
        public System.Guid ID { get; set; }
        public System.Guid EstimationID { get; set; }
        public int AllowanceType { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> NoOfPersons { get; set; }
        public Nullable<int> NoOfDays { get; set; }
        public Nullable<bool> IsCompleteSet { get; set; }
        public Nullable<bool> IsExclTax { get; set; }
        public decimal SubTotal { get; set; }
    
        public virtual Estimation Estimation { get; set; }
    }
}