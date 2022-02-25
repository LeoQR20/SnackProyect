using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        public void DeleteUsuario()
        {
            throw new NotImplementedException();
        }

        public User GetUsuario(int id, string password)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            // Encriptar el password para poder compararlo
            //string crytpPasswd = Cryptography.EncrypthAES(password);
            return repository.GetUsuario(id, password);
        }

        public User GetUsuarioByID(int id)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            User oUsuario = repository.GetUsuarioByID(id);
            //oUsuario.Contraseña = Cryptography.DecrypthAES(oUsuario.Contraseña);
            return oUsuario;

        }

        public User Save(User usuario)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            //usuario.Contraseña = Cryptography.EncrypthAES(usuario.Contraseña);
            return repository.Save(usuario);
        }

    }
}
