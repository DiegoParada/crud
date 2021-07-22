using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelVehiculos
    {
        /// <summary>
        /// El metodo cargará obtendra los documentos.
        /// </summary>
        /// <returns></returns>
        public static DataTable ObtenerlistaVehiculos()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM Vehiculos";
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
        public static bool RegistrarVehiculo(string ptipovehiculo, string pmarcavehiculo, string pestadovehiculo, string pmatriculavehiculo, string paño)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO Vehiculo(Tipo_Vehiculo,Marca_Vehiculo,Estado_Vehiculo,Matricula_Vehiculo,Año) VALUES('{0}','{1}','{2}','{3}','{4}')", ptipovehiculo,pmarcavehiculo,pestadovehiculo,pmatriculavehiculo,paño), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}

