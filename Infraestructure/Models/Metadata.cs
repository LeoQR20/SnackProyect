using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    internal partial class UsuarioMetadata
    {
        [Required(ErrorMessage = "{0} es un dato requerido")]
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
