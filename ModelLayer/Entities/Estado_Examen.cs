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
    
    
    public partial class Estado_Examen
    {
        public Estado_Examen()
        {
            this.Examen = new HashSet<Examen>();
        }
    
        public int id_estado { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<Examen> Examen { get; set; }
    }
}
