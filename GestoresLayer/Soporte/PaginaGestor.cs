using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace GestoresLayer
{
    public class PaginaGestor
    {
        public static List<Pagina> paginasGetByRol(int idRol)
        {
            try
            {

                ColegiosEntities contexto = new ColegiosEntities();

                var rol = contexto.Rol.Where(x => x.id_rol == idRol).FirstOrDefault();

                List<Pagina> paginasResult = new List<Pagina>();

                if (rol != null)
                {
                    paginasResult = rol.Pagina.ToList();
                }

                return paginasResult;

            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "PaginaGestor", "paginasGetByRol");
                throw ex;
            }
        }

        public static bool agregarPaginaARol(int id_rol, int id_pagina, ref string mensaje)
        {
            bool agregado = false;
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                Rol rol = contexto.Rol.Where(x => x.id_rol == id_rol).FirstOrDefault();

                if(rol != null)
                {
                    Pagina pagina = contexto.Pagina.Where(x => x.id_pagina == id_pagina).FirstOrDefault();

                    if(pagina != null)
                    {
                        Pagina paginaExistenteEnRol = rol.Pagina.Where(x => x.id_pagina == id_pagina).FirstOrDefault();

                        if(paginaExistenteEnRol != null)
                        {
                            mensaje = "El rol ya contiene la página.";
                        }
                        else
                        {
                            rol.Pagina.Add(pagina);
                            contexto.SaveChanges();
                            agregado = true;
                        }
                    }
                    else
                    {
                        mensaje = "Error al obtener la página.";
                    }
                }
                else
                {
                    mensaje = "Error al obtener el rol.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return agregado;
        }

        public static bool quitarPaginaARol(int id_rol, int id_pagina, ref string mensaje)
        {
            bool quitado = false;
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                Rol rol = contexto.Rol.Where(x => x.id_rol == id_rol).FirstOrDefault();

                if (rol != null)
                {
                    Pagina pagina = contexto.Pagina.Where(x => x.id_pagina == id_pagina).FirstOrDefault();

                    if (pagina != null)
                    {
                        Pagina paginaExistenteEnRol = rol.Pagina.Where(x => x.id_pagina == id_pagina).FirstOrDefault();

                        if (paginaExistenteEnRol == null)
                        {
                            mensaje = "El rol no contiene la página.";
                        }
                        else
                        {
                            rol.Pagina.Remove(paginaExistenteEnRol);
                            contexto.SaveChanges();
                            quitado = true;
                        }
                    }
                    else
                    {
                        mensaje = "Error al obtener la página.";
                    }
                }
                else
                {
                    mensaje = "Error al obtener el rol.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return quitado;
        }

        public static List<Pagina> getAll()
        {
            try
            {

                ColegiosEntities contexto = new ColegiosEntities();

                return contexto.Pagina.ToList();

            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "PaginaGestor", "getAll");
                throw ex;
            }
        }
    }
}
