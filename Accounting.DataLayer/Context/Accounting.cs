//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting.DataLayer.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounting
    {
        public int AccountigID { get; set; }
        public int TypeID_typ { get; set; }
        public int CustomerID_Cus { get; set; }
        public string Amount { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string AccountingDescription { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual AccountingType AccountingType { get; set; }
    }
}
