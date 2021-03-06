//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DG.DentneD.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoices
    {
        public invoices()
        {
            this.estimates = new HashSet<estimates>();
            this.invoiceslines = new HashSet<invoiceslines>();
        }
    
        public int invoices_id { get; set; }
        public Nullable<int> doctors_id { get; set; }
        public Nullable<int> patients_id { get; set; }
        public string invoices_number { get; set; }
        public System.DateTime invoices_date { get; set; }
        public string invoices_doctor { get; set; }
        public string invoices_patient { get; set; }
        public string invoices_payment { get; set; }
        public string invoices_footer { get; set; }
        public decimal invoices_totalnet { get; set; }
        public decimal invoices_totalgross { get; set; }
        public decimal invoices_totaldue { get; set; }
        public decimal invoices_deductiontaxrate { get; set; }
        public bool invoices_ispaid { get; set; }
    
        public virtual doctors doctors { get; set; }
        public virtual ICollection<estimates> estimates { get; set; }
        public virtual patients patients { get; set; }
        public virtual ICollection<invoiceslines> invoiceslines { get; set; }
    }
}
