//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace visprog_uts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mahasiswa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mahasiswa()
        {
            this.Mahasiswa_MataKuliah = new HashSet<Mahasiswa_MataKuliah>();
        }
    
        public long id { get; set; }
        public string nama { get; set; }
        public string nrp { get; set; }
        public string jurusan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mahasiswa_MataKuliah> Mahasiswa_MataKuliah { get; set; }
    }
}
