using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista =  new List<Usuario>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    string query = "SELECT IdUsuario,Nombres,Apellidos,Correo,Clave,Reestablecer,Activo FROM USUARIO";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(
                                new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    Nombres = Convert.ToString(dr["Nombres"]),
                                    Apellidos = Convert.ToString(dr["Apellidos"]),
                                    Correo = Convert.ToString(dr["Correo"]),
                                    Clave = Convert.ToString(dr["Clave"]),
                                    Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Usuario>();
            }

            return lista;
        }
    }
}
