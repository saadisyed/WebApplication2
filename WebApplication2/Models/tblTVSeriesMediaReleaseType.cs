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
    
    public partial class tblTVSeriesMediaReleaseType
    {
        public long ID_TVSeries { get; set; }
        public long ID_Media { get; set; }
        public long ID_ReleaseType { get; set; }
    
        public virtual tblMedia tblMedia { get; set; }
        public virtual tblReleaseType tblReleaseType { get; set; }
        public virtual tblTVSery tblTVSery { get; set; }
    }
}
