//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineStoreRestApi.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_address()
        {
            this.tbl_customer1 = new HashSet<tbl_customer>();
            this.tbl_orders = new HashSet<tbl_orders>();
        }
    
        public int id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public string address { get; set; }
    
        public virtual tbl_customer tbl_customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_customer> tbl_customer1 { get; set; }
        public virtual tbl_customer tbl_customer2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_orders> tbl_orders { get; set; }
    }
}
