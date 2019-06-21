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
    
    
    public partial class Plan
    {
        public Plan()
        {
            this.Colegio = new HashSet<Colegio>();
        }
    
        public int id_plan { get; set; }
        public string nombre { get; set; }
        public Nullable<int> cantidad_alumnos { get; set; }
        public Nullable<bool> habilitado { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<int> usuario_alta { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public Nullable<int> usuario_baja { get; set; }
    
        public virtual ICollection<Colegio> Colegio { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
