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
    
    public partial class CamereUnitati
    {
        public int IDcamunit { get; set; }
        public int IDUnitate { get; set; }
        public int IDTipCamera { get; set; }
        public int NrDisp { get; set; }
        public int Pret { get; set; }
    
        public virtual TipCamera TipCamera { get; set; }
        public virtual Unitati Unitati { get; set; }
    }
}
