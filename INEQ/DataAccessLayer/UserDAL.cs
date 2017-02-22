#region using directives
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace DataAccessLayer
{
    public class UserDAL
    {
        private static IneqContext db = new IneqContext();
        public static string CONNECTIONSTRING = "server=localhost;uid=root;pwd=melapelas5225.;database=Ineq";

        public static bool iniciarSesion(string us, string pwd)
        {
            //return db.Users.Where(u => u.Username == us && u.Password == pwd).Count() > 0; //--> LINQ LAMBDA

            try
            {
                //1° - Creamos objeto conexion y le pasamos la cadena de conexion
                //ubicada en el archivo App.Config
                MySqlConnection sqlConn = new MySqlConnection(CONNECTIONSTRING);

                //2° - Abrir la conexion
                sqlConn.Open();

                //3° - Crear el query que utilizaras
                string query = "SELECT * FROM User WHERE Username = @username AND Password = @password";

                //4° - Crear el objeto comando al cual le pasas el query
                //y la conexion para ejecutar el query antes mencionado
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);

                //5° - Agregar los parametros necesarios
                cmd.Parameters.AddWithValue("@username", us);
                cmd.Parameters.AddWithValue("@password", pwd);

                //6° - Ejecutar el query y guardar el resultado
                MySqlDataReader dr = cmd.ExecuteReader();

                //7° - Validar si contiene registros
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
