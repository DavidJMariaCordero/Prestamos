using System;
using System.Linq;
using System.Linq.Expressions;
using Prestamos;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Prestamos.DAL;
using Prestamos.Entidades;
using System.Collections;

namespace Prestamos.BLL
{
    public class PrestamoBLL
    {
        public static bool Save(Prestamo prestamo)
        {
            if (!Exist(prestamo.PrestamoId))
                return Insert(prestamo);
            else
                return Modify(prestamo);
        }


        private static bool Insert(Prestamo prestamo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                bool encontrado = PersonaBLL.AsignarBalance(prestamo.PersonaId,prestamo.Monto);
                prestamo.Balance = prestamo.Monto;
                contexto.Prestamo.Add(prestamo);
                if(contexto.SaveChanges() > 0 && encontrado == true)
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modify(Prestamo prestamo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                PersonaBLL.ModificarBalance(prestamo.PersonaId, prestamo.Balance, prestamo.Monto);
                prestamo.Balance = prestamo.Monto;
                contexto.Entry(prestamo).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Delete(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var prestamo = contexto.Prestamo.Find(id);
                if (prestamo != null)
                {
                    PersonaBLL.EliminarBalance(prestamo.PersonaId,prestamo.Balance);
                    contexto.Prestamo.Remove(prestamo);//remover la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Prestamo Search(int id)
        {
            Contexto contexto = new Contexto();
            Prestamo prestamo;
            try
            {
                prestamo = contexto.Prestamo.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return prestamo;
        }

        public static bool Exist(int id){
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Prestamo.Any(p => p.PrestamoId == id);
            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }
            return encontrado;
        }

        public static List<Prestamo> GetList(Expression<Func<Prestamo, bool>> criterio)
        {
            List<Prestamo> lista = new List<Prestamo>();
            Contexto contexto = new Contexto();
            try
            {
                //obtener la lista y filtrarla según el criterio recibido por parametro Where(criterio)..
                lista = contexto.Prestamo.Where(criterio).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Prestamo> GetList()
        {
            List<Prestamo> lista = new List<Prestamo>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Prestamo.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
        
    }
}