//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCodec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCodec()
        {
            this.tblEpisodeMediaCodecs = new HashSet<tblEpisodeMediaCodec>();
            this.tblMovies = new HashSet<tblMovie>();
            this.tblTVSeriesMediaCodecs = new HashSet<tblTVSeriesMediaCodec>();
        }
    
        public long ID_Codec { get; set; }
        public string Codec { get; set; }
        public string Description { get; set; }
        public Nullable<int> FK_UserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEpisodeMediaCodec> tblEpisodeMediaCodecs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMovie> tblMovies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTVSeriesMediaCodec> tblTVSeriesMediaCodecs { get; set; }
    }
}
