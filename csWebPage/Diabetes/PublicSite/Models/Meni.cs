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
    
    public partial class Meni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meni()
        {
            this.Obroks = new HashSet<Obrok>();
        }
    
        public int IDMeni { get; set; }
        public System.DateTime DatumKreiranja { get; set; }
        public int BrojObroka { get; set; }
        public Nullable<int> KorisnikID { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obrok> Obroks { get; set; }
    }
}
