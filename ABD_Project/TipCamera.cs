//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABD_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipCamera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipCamera()
        {
            this.CamereOcupate = new HashSet<CamereOcupate>();
            this.CamereUnitati = new HashSet<CamereUnitati>();
            this.Rezervari = new HashSet<Rezervari>();
        }
    
        public int IDTipCamera { get; set; }
        public int NrLocuri { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CamereOcupate> CamereOcupate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CamereUnitati> CamereUnitati { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervari> Rezervari { get; set; }
    }
}
