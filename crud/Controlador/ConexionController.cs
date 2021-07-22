using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class ConexionController
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection valor;
            valor = Conexion.getConnect();
            return valor;
        }
    }
}
