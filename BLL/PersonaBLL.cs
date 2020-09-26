using System;
using System.Linq;
using System.Linq.Expressions;
using Prestamos;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Prestamos.DAL;
using Prestamos.Entidades;

namespace Prestamos.BLL
{
    public class PersonaBLL
    {
        public static bool Save(Persona persona)
        {
            if (!Exist(persona.PersonaId))
                return Insert(persona);
            else
                return Modify(persona);
        }
        private static bool Insert(Persona persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Persona.Add(persona);
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

        public static bool Modify(Persona persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(persona).State = EntityState.Modified;
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
                var persona = contexto.Persona.Find(id);
                if (persona != null)
                {
                    contexto.Persona.Remove(persona);//remover la entidad
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

        public static Persona Search(int id)
        {
            Contexto contexto = new Contexto();
            Persona persona;
            try
            {
                persona = contexto.Persona.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return persona;
        }

        public static bool Exist(int id){
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Persona.Any(p => p.PersonaId == id);
            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }
            return encontrado;
        }

        public static bool AsignarBalance(int id, double balance){
            
            Persona pers = Search(id);
            if(pers != null){
                pers.Balance += balance;
                Save(pers);
                return true;
            }
            else
                return false;
        }

        public static bool ModificarBalance(int id, double balance, double Monto){
            
            Persona pers = Search(id);
            if(pers != null){
                pers.Balance -= balance;
                pers.Balance += Monto;
                Save(pers);
                return true;
            }
            else
                return false;
        }
        public static bool EliminarBalance(int id, double balance){
            
            Persona pers = Search(id);
            if(pers != null){
                pers.Balance -= balance;
                Save(pers);
                return true;
            }
            else
                return false;
        }
    }
}