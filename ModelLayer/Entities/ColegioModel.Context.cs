﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ColegiosEntities : DbContext
    {
        public ColegiosEntities()
            : base("name=ColegiosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno_Curso> Alumno_Curso { get; set; }
        public virtual DbSet<Alumno_Examen> Alumno_Examen { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Colegio> Colegio { get; set; }
        public virtual DbSet<Colegio_Usuario> Colegio_Usuario { get; set; }
        public virtual DbSet<Contacto_Colegio> Contacto_Colegio { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Estado_Asistencia> Estado_Asistencia { get; set; }
        public virtual DbSet<Estado_Examen> Estado_Examen { get; set; }
        public virtual DbSet<Estado_Temario> Estado_Temario { get; set; }
        public virtual DbSet<Examen> Examen { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Materia_Curso> Materia_Curso { get; set; }
        public virtual DbSet<Participante_Reunion> Participante_Reunion { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Reunion> Reunion { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Rol_Usuario> Rol_Usuario { get; set; }
        public virtual DbSet<Tema_Examen> Tema_Examen { get; set; }
        public virtual DbSet<Temario> Temario { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Barrio> Barrio { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Pagina> Pagina { get; set; }
        public virtual DbSet<Codigo_Colegio> Codigo_Colegio { get; set; }
    }
}
