//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA45Team07B
{
    using System;
    using System.Collections.Generic;
    
    public partial class RFIDTag
    {
        public RFIDTag()
        {
            this.IssueTrans = new HashSet<IssueTran>();
            this.StockAdjustments = new HashSet<StockAdjustment>();
            this.Availability = "y";
            this.Discontinued = "n";
        }
    
        public string RFID { get; set; }
        public long BookID { get; set; }
        public string Discontinued { get; set; }
        public Nullable<long> LastTransactionID { get; set; }
        public string Availability { get; set; }
    
        public virtual Book Books { get; set; }
        public virtual ICollection<IssueTran> IssueTrans { get; set; }
        public virtual ICollection<StockAdjustment> StockAdjustments { get; set; }
    }
}