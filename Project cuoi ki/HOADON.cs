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
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.chitiethoadons = new HashSet<chitiethoadon>();
        }
    
        public string MAHD { get; set; }
        public Nullable<System.DateTime> NGAYDEN { get; set; }
        public Nullable<int> THANHTIEN { get; set; }
        public Nullable<int> MAKM { get; set; }
        public string MABN { get; set; }
        public string TRANGTHAI { get; set; }
        public string MANV { get; set; }
    
        public virtual BAN BAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}