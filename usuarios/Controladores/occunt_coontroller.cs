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
    class occunt_coontroller
    {
        private Modelos.roles_model roles_Model = new Modelos.roles_model();
        private readonly conexion cn = new conexion();

        public string Password { get; private set; }
        public object Username { get; private set; }

        public usuario_model login(string username, string password){ 
            using (var conexion =cn.ObtenerConexion())
            {
                string cadena = $"select * from Usuarios " +
                    $"inner join Roles on Usuarios.Roles_id = Roles.Rol_Id " +
                    $"where Usuarios.Username = '{Username}'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            if (Password == lector["Password"].ToString())
                            {
                                return new usuario_model
                                {
                                    Id_User = (int)lector["Id_User"],
                                    Username = lector["Username"].ToString(),
                                    Password = lector["Password"].ToString(),
                                    Roles_id = (int)lector["Roles_id"],
                                    Detalle_Rol = lector["Detalle"].ToString(),
                                };
                            }
                            else
                            {
                                return new usuario_model();
                            }
                        }
                        else
                        {
                            return new usuario_model();
                        }

                    }
                }
            }
        }
    }
}
