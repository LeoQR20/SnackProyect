using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceUsuario
    {
        User GetUsuario(int ID, string password);
        User GetUsuarioByID(int id);
        void DeleteUsuario();
        User Save(User user);
    }
}
