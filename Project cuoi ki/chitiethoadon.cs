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
    
    public partial class chitiethoadon
    {
        public int MACTHD { get; set; }
        public string MAMA { get; set; }
        public string MAHD { get; set; }
        public string MABN { get; set; }
        public Nullable<int> SOLUONG { get; set; }
    
        public virtual BAN BAN { get; set; }
        public virtual HOADON HOADON { get; set; }
        public virtual MONAN MONAN { get; set; }
    }
}
