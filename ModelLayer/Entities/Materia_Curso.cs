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
    
    
    public partial class Materia_Curso
    {
        public int id_materia { get; set; }
        public int id_curso { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<int> usuario_alta { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public Nullable<int> usuario_baja { get; set; }
    
        public virtual Curso Curso { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
