//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PublicSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Obrok
    {
        public int IDObrok { get; set; }
        public Nullable<int> MeniID { get; set; }
        public Nullable<int> NazivObrokaID { get; set; }
        public Nullable<int> NamirnicaID { get; set; }
    
        public virtual Meni Meni { get; set; }
        public virtual Namirnica Namirnica { get; set; }
        public virtual NazivObroka NazivObroka { get; set; }
    }
}