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
    
    
    public partial class Reunion
    {
        public Reunion()
        {
            this.Participante_Reunion = new HashSet<Participante_Reunion>();
        }
    
        public int id_reunion { get; set; }
        public Nullable<System.DateTime> fecha_reunion { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<int> usuario_alta { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public Nullable<int> usuario_baja { get; set; }
        public Nullable<int> id_colegio { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }
    
        public virtual Colegio Colegio { get; set; }
        public virtual ICollection<Participante_Reunion> Participante_Reunion { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
