using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ClientesController
    {
        public static DataTable CargarClientes_Controller()
        {
            return ModelClientes.ObtenerListaClientes();
        }

        //ATRIBUTOS
        public int idcliente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string dui { get; set; }

        //CONSTRUCTOR
        public ClientesController() { }

        public bool InsertarDatos_Controller()
        {
            return ModelClientes.RegistrarEmpleado(nombres, apellidos, telefono, correo, dui);
        }
    }
}
