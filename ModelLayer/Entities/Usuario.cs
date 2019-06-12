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
    
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Alumno_Curso = new HashSet<Alumno_Curso>();
            this.Alumno_Curso1 = new HashSet<Alumno_Curso>();
            this.Alumno_Curso2 = new HashSet<Alumno_Curso>();
            this.Alumno_Examen = new HashSet<Alumno_Examen>();
            this.Alumno_Examen1 = new HashSet<Alumno_Examen>();
            this.Alumno_Examen2 = new HashSet<Alumno_Examen>();
            this.Asistencia = new HashSet<Asistencia>();
            this.Asistencia1 = new HashSet<Asistencia>();
            this.Asistencia2 = new HashSet<Asistencia>();
            this.Aula = new HashSet<Aula>();
            this.Aula1 = new HashSet<Aula>();
            this.Colegio = new HashSet<Colegio>();
            this.Colegio1 = new HashSet<Colegio>();
            this.Colegio_Usuario = new HashSet<Colegio_Usuario>();
            this.Colegio_Usuario1 = new HashSet<Colegio_Usuario>();
            this.Colegio_Usuario2 = new HashSet<Colegio_Usuario>();
            this.Contacto_Colegio = new HashSet<Contacto_Colegio>();
            this.Contacto_Colegio1 = new HashSet<Contacto_Colegio>();
            this.Curso = new HashSet<Curso>();
            this.Curso1 = new HashSet<Curso>();
            this.Curso2 = new HashSet<Curso>();
            this.Curso3 = new HashSet<Curso>();
            this.Examen = new HashSet<Examen>();
            this.Examen1 = new HashSet<Examen>();
            this.Materia_Curso = new HashSet<Materia_Curso>();
            this.Materia_Curso1 = new HashSet<Materia_Curso>();
            this.Participante_Reunion = new HashSet<Participante_Reunion>();
            this.Participante_Reunion1 = new HashSet<Participante_Reunion>();
            this.Participante_Reunion2 = new HashSet<Participante_Reunion>();
            this.Plan = new HashSet<Plan>();
            this.Plan1 = new HashSet<Plan>();
            this.Reunion = new HashSet<Reunion>();
            this.Reunion1 = new HashSet<Reunion>();
            this.Rol_Usuario = new HashSet<Rol_Usuario>();
            this.Rol_Usuario1 = new HashSet<Rol_Usuario>();
            this.Rol_Usuario2 = new HashSet<Rol_Usuario>();
            this.Tema_Examen = new HashSet<Tema_Examen>();
            this.Tema_Examen1 = new HashSet<Tema_Examen>();
            this.Temario = new HashSet<Temario>();
            this.Temario1 = new HashSet<Temario>();
            this.Turno = new HashSet<Turno>();
            this.Turno1 = new HashSet<Turno>();
            this.Usuario1 = new HashSet<Usuario>();
            this.Usuario11 = new HashSet<Usuario>();
        }
    
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombre_usuario { get; set; }
        public string password { get; set; }
        public Nullable<bool> habilitado { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string password_recovery { get; set; }
        public Nullable<int> id_barrio { get; set; }
        public Nullable<int> id_localidad { get; set; }
        public Nullable<int> id_provincia { get; set; }
        public Nullable<int> id_pais { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<int> usuario_alta { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public Nullable<int> usuario_baja { get; set; }
    
        public virtual ICollection<Alumno_Curso> Alumno_Curso { get; set; }
        public virtual ICollection<Alumno_Curso> Alumno_Curso1 { get; set; }
        public virtual ICollection<Alumno_Curso> Alumno_Curso2 { get; set; }
        public virtual ICollection<Alumno_Examen> Alumno_Examen { get; set; }
        public virtual ICollection<Alumno_Examen> Alumno_Examen1 { get; set; }
        public virtual ICollection<Alumno_Examen> Alumno_Examen2 { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
        public virtual ICollection<Asistencia> Asistencia1 { get; set; }
        public virtual ICollection<Asistencia> Asistencia2 { get; set; }
        public virtual ICollection<Aula> Aula { get; set; }
        public virtual ICollection<Aula> Aula1 { get; set; }
        public virtual Barrio Barrio { get; set; }
        public virtual ICollection<Colegio> Colegio { get; set; }
        public virtual ICollection<Colegio> Colegio1 { get; set; }
        public virtual ICollection<Colegio_Usuario> Colegio_Usuario { get; set; }
        public virtual ICollection<Colegio_Usuario> Colegio_Usuario1 { get; set; }
        public virtual ICollection<Colegio_Usuario> Colegio_Usuario2 { get; set; }
        public virtual ICollection<Contacto_Colegio> Contacto_Colegio { get; set; }
        public virtual ICollection<Contacto_Colegio> Contacto_Colegio1 { get; set; }
        public virtual ICollection<Curso> Curso { get; set; }
        public virtual ICollection<Curso> Curso1 { get; set; }
        public virtual ICollection<Curso> Curso2 { get; set; }
        public virtual ICollection<Curso> Curso3 { get; set; }
        public virtual ICollection<Examen> Examen { get; set; }
        public virtual ICollection<Examen> Examen1 { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual ICollection<Materia_Curso> Materia_Curso { get; set; }
        public virtual ICollection<Materia_Curso> Materia_Curso1 { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Participante_Reunion> Participante_Reunion { get; set; }
        public virtual ICollection<Participante_Reunion> Participante_Reunion1 { get; set; }
        public virtual ICollection<Participante_Reunion> Participante_Reunion2 { get; set; }
        public virtual ICollection<Plan> Plan { get; set; }
        public virtual ICollection<Plan> Plan1 { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Reunion> Reunion { get; set; }
        public virtual ICollection<Reunion> Reunion1 { get; set; }
        public virtual ICollection<Rol_Usuario> Rol_Usuario { get; set; }
        public virtual ICollection<Rol_Usuario> Rol_Usuario1 { get; set; }
        public virtual ICollection<Rol_Usuario> Rol_Usuario2 { get; set; }
        public virtual ICollection<Tema_Examen> Tema_Examen { get; set; }
        public virtual ICollection<Tema_Examen> Tema_Examen1 { get; set; }
        public virtual ICollection<Temario> Temario { get; set; }
        public virtual ICollection<Temario> Temario1 { get; set; }
        public virtual ICollection<Turno> Turno { get; set; }
        public virtual ICollection<Turno> Turno1 { get; set; }
        public virtual ICollection<Usuario> Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }
        public virtual ICollection<Usuario> Usuario11 { get; set; }
        public virtual Usuario Usuario3 { get; set; }
    }
}
