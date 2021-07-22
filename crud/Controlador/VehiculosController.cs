using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;


namespace Controlador
{
    public class VehiculosController
    {
        public static DataTable CargarVehiculos_Controller()
        {
            return ModelVehiculos.ObtenerlistaVehiculos();
        }

        //ATRIBUTOS
        public int idvehiculo { get; set; }
        public string tipovehiculo { get; set; }
        public string marcavehiculo { get; set; }
        public string estadovehiculo { get; set; }
        public string matriculavehiculo { get; set; }
        public string año { get; set; }

        //CONSTRUCTOR
        public VehiculosController() { }

        public bool InsertarDatos_Controller()
        {
            return ModelVehiculos.RegistrarVehiculo(tipovehiculo,marcavehiculo,estadovehiculo,matriculavehiculo,año);
        }
    }
}
