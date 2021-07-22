using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;

namespace Vista
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        public DataTable datos;


        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        void Conectar()
        {
            MySqlConnection retorno = ConexionController.ObtenerConexion();
            if (retorno != null)
            {
                MessageBox.Show("Conexión establecida con exito", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo establecer una conexión con el servidor, verifique su conexión a internet y si el problema persiste consulte con el administrador del sistema.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        void CargarGridDatos()
        {
            datos = ClientesController.CargarClientes_Controller();
            DgvCliente.DataSource = datos;
        }

        void CargarVehiculos()
        {
            datos = VehiculosController.CargarVehiculos_Controller();
            DgvCliente.DataSource = datos;
        }

        void InsertoDatos()
        {
            ClientesController agregar = new ClientesController();
            agregar.nombres = txtNombresCli.Text;
            agregar.apellidos = txtApellidosCli.Text;
            agregar.telefono = txtTelefonoCli.Text;
            agregar.correo = txtCorreoCli.Text;
            agregar.dui = txtDuiCli.Text;
            bool respuesta = agregar.InsertarDatos_Controller();
            if (respuesta == true)
            {
                MessageBox.Show("Cliente ingresado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El cliente no pudo registrado.", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void RegistrarVehiculos()
        {
            VehiculosController agregar = new VehiculosController();
            agregar.tipovehiculo = txtTipoVehiculo.Text;
            agregar.marcavehiculo = txtMarcaVehiculo.Text;
            agregar.estadovehiculo = txtEstadoVehiculo.Text;
            agregar.matriculavehiculo = txtMatriculaVehiculo.Text;
            agregar.año = dtAñoVehículo.Text;
            bool respuesta = agregar.InsertarDatos_Controller();
            if (respuesta == true)
            {
                MessageBox.Show("Vehiculo ingresado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El Vehiculo no pudo registrado.", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            InsertoDatos();
            CargarGridDatos();
        }

        private void BtnAgregarDescripcionVehiculo_Click(object sender, EventArgs e)
        {
            RegistrarVehiculos();
            CargarVehiculos();
        }
    }
}
