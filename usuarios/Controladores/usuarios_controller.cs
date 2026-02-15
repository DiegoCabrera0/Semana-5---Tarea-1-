using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usuarios.Modelos;
using usuarios.Config;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace usuarios.Controladores
{
    class usuarios_controller
    {
        private usuario_model usuario_Model = new usuario_model();
        private readonly conexion cn = new conexion();

        public object Id_User { get; private set; }

        public List<usuario_model> todos(List<usuario_model> usuario) {
            var lista_usuarios = new List<usuario_model>();
            using (var conexion = cn.ObtenerConexion())
            {
                conexion.Open();
                string cadena = $"select * from Usuarios " +
                    $"inner join Roles on Usuarios.Roles_id = Roles.Rol_Id " +
                    $"where (Usuarios.disponibilidad = '1' and Usurios.Id_User ={Id_User}";
                using (var comando = new SqlCommand(cadena,conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (!lector.Read()) return null; 
                        {
                            var usuario = new usuario_model
                            {
                                createAT = Convert.ToDateTime(lector["cretedAt"].ToString()),
                                Detalle_Rol = lector["Detalle"].ToString(),
                                Disponibilidad = (int)lector["Disponibilidad"],
                                Id_User = (int)lector["Id_User"],
                                Password = lector["Password"].ToString(),
                                Roles_id = (int)lector["Roles_id"],
                                updateAT = Convert.ToDateTime(lector["updateAT"].ToString()),
                                Username = lector["Username"].ToString(),
                            };
                         return "ok";
                        }
                    }
                }

            }
        }
        public usuario_model uno(int Id_User) {return null; }
        public string insertar(usuario_model usuario) {return "ok";}
        public string actualizar(usuario_model usuario) { return "ok";}
        public string eliminar(int Id_User) { return "ok"; }
    
    }
}
