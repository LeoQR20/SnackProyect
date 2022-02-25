using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
   public interface IRepositoryUsuario
    {
        User GetUsuario(int id, string password);

        User GetUsuarioByID(int id);

        void DeleteUsuario();

        User Save(User user);
    }
}
