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
    
    public partial class Mahasiswa_MataKuliah
    {
        public long id { get; set; }
        public long mahasiswa_id { get; set; }
        public long matakuliah_id { get; set; }
        public string status { get; set; }
    
        public virtual Mahasiswa Mahasiswa { get; set; }
        public virtual MataKuliah MataKuliah { get; set; }
    }
}
