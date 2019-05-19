using ClasesPrincipales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente p = new Cliente();
            p.Nombre = txtNombre.Text;
            p.direccion = txtDireccion.Text;
            p.ruc = txtRuc.Text;
            p.Telefono = txtTelefono.Text;


            Cliente.AgregarCliente(p);
            ActualizarListaClientees();


        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCliente.SelectedItem != null)
            {
                Cliente ClienteSeleccionado = (Cliente)lstCliente.SelectedItem;

                txtNombre.Text = ClienteSeleccionado.Nombre;
                txtRuc.Text = ClienteSeleccionado.ruc;
                txtDireccion.Text = ClienteSeleccionado.direccion;
                txtTelefono.Text = ClienteSeleccionado.Telefono;
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtRuc.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            txtNombre.Focus();         
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstCliente.SelectedItem != null)
            {
                Cliente ClienteSeleccionado = (Cliente)lstCliente.SelectedItem;

                ClienteSeleccionado.Nombre = txtNombre.Text;
                ClienteSeleccionado.direccion = txtDireccion.Text;
                ClienteSeleccionado.ruc = txtRuc.Text;
                ClienteSeleccionado.Telefono = txtTelefono.Text;

                ActualizarListaClientees();
            }
        }

        private void ActualizarListaClientees()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerClientees();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCliente.SelectedItem != null)
            {
                Cliente ClienteSeleccionado = (Cliente)lstCliente.SelectedItem;

                Cliente.EliminarCliente(ClienteSeleccionado);
                ActualizarListaClientees();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
