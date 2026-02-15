using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usuarios.Modelos
{
    internal class usuario_model
    {
        public int Id_User { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Disponibilidad { get; set; }
        public DateTime createAT { get; set; }
        public DateTime updateAT { get; set; }
        public int Roles_Rol { get; set; }
        public string Detalle_Rol { get; set; } = null;
        public int Roles_id { get; internal set; }
    }
}
