using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelClientes
    {
        /// <summary>
        /// El metodo cargará obtendra los documentos.
        /// </summary>
        /// <returns></returns>
        public static DataTable ObtenerListaClientes()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM Clientes";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        //CRUD
        public static bool RegistrarEmpleado(string pnombres, string papellidos, string ptelefono, string pcorreo, string pDUI)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO Cliente(nombre_cli,apellido_cli,telefono_cli,correo_cli,dui_cli) VALUES('{0}','{1}','{2}','{3}','{4}')", pnombres, papellidos, ptelefono, pcorreo, pDUI), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = null;
            }
        }
    }
}
