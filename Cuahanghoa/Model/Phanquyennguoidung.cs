//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cuahanghoa.Model
{
    using Cuahanghoa.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class Phanquyennguoidung: BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phanquyennguoidung()
        {
            this.Nguoidung = new HashSet<Nguoidung>();
        }

        private int _Idquyen;
        public int Idquyen { get => _Idquyen; set { _Idquyen = value; OnPropertyChanged(); } }

        private string _Tenhienthi;
        public string Tenhienthi { get => _Tenhienthi; set { _Tenhienthi = value; OnPropertyChanged(); } }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nguoidung> Nguoidung { get; set; }
    }
}
