//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    
    public partial class Pais
    {
        public Pais()
        {
            this.Colegio = new HashSet<Colegio>();
            this.Provincia = new HashSet<Provincia>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<Colegio> Colegio { get; set; }
        public virtual ICollection<Provincia> Provincia { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
