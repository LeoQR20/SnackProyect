using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using web.Utils;

namespace Infraestructure.Repository
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        public void DeleteUsuario()
        {
            throw new NotImplementedException();
        }

        public User GetUsuario(int ID, string password)
        {
            User oUsuario = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    oUsuario = ctx.Users.
                        Where(p => p.ID.Equals(ID) && p.Password == password).
                        FirstOrDefault<User>();
                }
                if (oUsuario != null)
                    oUsuario = GetUsuarioByID(oUsuario.ID);
                return oUsuario;
            }
            catch (DbUpdateException dbEx)
            {

                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";

                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }

        public User GetUsuarioByID(int id)
        {
            //IL_00b2: Expected O, but got Unknown
            User usuario = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {

                }
                return usuario;
            }
            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }

        public User Save(User User)
        {
            int retorno = 0;
            User oUsuario = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    oUsuario = GetUsuarioByID(User.ID);
                    if (oUsuario == null)
                    {

                        ctx.Users.Add(User);

                    }
                    else
                    {
                        ctx.Entry(User).State = System.Data.Entity.EntityState.Modified;
                    }
                    retorno = ctx.SaveChanges();
                }
                if (retorno >= 0)
                    oUsuario = GetUsuarioByID(User.ID);
                return oUsuario;
            }

            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }
    }
}
