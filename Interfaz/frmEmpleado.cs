using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesPrincipales;

namespace Interfaz
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado p = new Empleado();
            p.Nombre = txtNombre.Text;
            p.direccion = txtDireccion.Text;
            p.ruc = txtRuc.Text;
            p.Telefono = txtTelefono.Text;


            Empleado.AgregarEmpleado(p);
            ActualizarListaEmpleadoes();


        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmpleado.SelectedItem != null)
            {
                Empleado EmpleadoSeleccionado = (Empleado)lstEmpleado.SelectedItem;

                txtNombre.Text = EmpleadoSeleccionado.Nombre;
                txtRuc.Text = EmpleadoSeleccionado.ruc;
                txtDireccion.Text = EmpleadoSeleccionado.direccion;
                txtTelefono.Text = EmpleadoSeleccionado.Telefono;
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
            if (lstEmpleado.SelectedItem != null)
            {
                Empleado EmpleadoSeleccionado = (Empleado)lstEmpleado.SelectedItem;

                EmpleadoSeleccionado.Nombre = txtNombre.Text;
                EmpleadoSeleccionado.direccion = txtDireccion.Text;
                EmpleadoSeleccionado.ruc = txtRuc.Text;
                EmpleadoSeleccionado.Telefono = txtTelefono.Text;

                ActualizarListaEmpleadoes();
            }
        }

        private void ActualizarListaEmpleadoes()
        {
            lstEmpleado.DataSource = null;
            lstEmpleado.DataSource = Empleado.ObtenerEmpleadoes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEmpleado.SelectedItem != null)
            {
                Empleado EmpleadoSeleccionado = (Empleado)lstEmpleado.SelectedItem;

                Empleado.EliminarEmpleado(EmpleadoSeleccionado);
                ActualizarListaEmpleadoes();
            }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
