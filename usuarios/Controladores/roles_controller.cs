using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usuarios.Modelos;
using usuarios.Config;
using System.Data.SqlClient;
using System.Data ;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace usuarios.Controladores
{
    class roles_controller
    {
        private Modelos.roles_model roles_Model = new Modelos.roles_model();
        private readonly conexion cn = new conexion();

        public string Detalle { get; private set; }
        public int Rol_Id { get; private set; }

        public List<roles_model> Todos()
        {
            var listaroles = new List<roles_model>();
            using (var conexion = cn.ObtenerConexion())
            {
                string cadena = "SELECT * FROM roles";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var rol = new roles_model
                            {
                                Detalle = lector["Detalle"].ToString(),
                                Rol_Id = Convert.ToInt32(lector["Rol_Id"])
                            };
                            listaroles.Add(rol);
                        }
                    }
                }
            }
            return listaroles;  
        }

    }
}
    