//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_cuoi_ki
{
    using System;
    using System.Collections.Generic;
    
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            this.chitiethoadons = new HashSet<chitiethoadon>();
        }
    
        public string MAMA { get; set; }
        public string TENMA { get; set; }
        public Nullable<int> GIABAN { get; set; }
        public string MALMA { get; set; }
        public Nullable<int> SOLUONGHANGHOA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }
        public virtual LOAIMONAN LOAIMONAN { get; set; }
    }
}
