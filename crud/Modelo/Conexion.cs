using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {
        /// <summary>
        /// El método getConnect servirá para conectar el sistema con la base de datos
        /// </summary>
        /// <returns>El retorno será una conexión de tipo MySql</returns>
        public static MySqlConnection getConnect()
        {
            MySqlConnection connect;
            try
            {
                string server, database, user, password;
                server = "127.0.0.1";
                database = "dbrepuestos";
                user = "root";
                password = "";
                connect = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                              "; uid = " + user +
                                              "; pwd = " + password);
                connect.Open();
                return connect;
            }
            catch (Exception)
            {
                return connect = null;
            }
        }
    }
}