//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    
    public partial class Barrio
    {
        public Barrio()
        {
            this.Colegio = new HashSet<Colegio>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int id_barrio { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> id_localidad { get; set; }
    
        public virtual Localidad Localidad { get; set; }
        public virtual ICollection<Colegio> Colegio { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
