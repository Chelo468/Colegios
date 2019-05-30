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
    
    public partial class Examen
    {
        public Examen()
        {
            this.Alumno_Examen = new HashSet<Alumno_Examen>();
            this.Tema_Examen = new HashSet<Tema_Examen>();
        }
    
        public int id_examen { get; set; }
        public Nullable<int> id_curso { get; set; }
        public Nullable<int> id_materia { get; set; }
        public Nullable<int> id_estado { get; set; }
        public Nullable<int> año { get; set; }
        public Nullable<System.DateTime> fecha_examen { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<int> usuario_alta { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public Nullable<int> usuario_baja { get; set; }
    
        public virtual ICollection<Alumno_Examen> Alumno_Examen { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Estado_Examen Estado_Examen { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual ICollection<Tema_Examen> Tema_Examen { get; set; }
    }
}
