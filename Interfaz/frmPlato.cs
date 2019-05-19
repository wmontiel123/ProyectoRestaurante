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
    public partial class frmPlato : Form
    {
        public frmPlato()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Plato p = new Plato();
            p.Nombre = txtNombre.Text;
            p.Precio = Convert.ToDouble(txtPrecio.Text);
            p.categoria = txtCategoria.Text;
            p.descuento = Convert.ToDouble(txtDescuento.Text);


            Plato.AgregarPlato(p);
            ActualizarListaPlatoes();


        }

        private void lstPlatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlato.SelectedItem != null)
            {
                Plato PlatoSeleccionado = (Plato)lstPlato.SelectedItem;

                txtNombre.Text = PlatoSeleccionado.Nombre;
                txtCategoria.Text = PlatoSeleccionado.categoria;
                txtPrecio.Text = Convert.ToString(PlatoSeleccionado.Precio);
                txtDescuento.Text = Convert.ToString(PlatoSeleccionado.descuento);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescuento.Text = string.Empty;

            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstPlato.SelectedItem != null)
            {
                Plato PlatoSeleccionado = (Plato)lstPlato.SelectedItem;

                PlatoSeleccionado.Nombre = txtNombre.Text;
                PlatoSeleccionado.Precio = Convert.ToDouble(txtPrecio.Text);
                PlatoSeleccionado.categoria = txtCategoria.Text;
                PlatoSeleccionado.descuento = Convert.ToDouble(txtDescuento.Text);

                ActualizarListaPlatoes();
            }
        }

        private void ActualizarListaPlatoes()
        {
            lstPlato.DataSource = null;
            lstPlato.DataSource = Plato.ObtenerPlatoes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPlato.SelectedItem != null)
            {
                Plato PlatoSeleccionado = (Plato)lstPlato.SelectedItem;

                Plato.EliminarPlato(PlatoSeleccionado);
                ActualizarListaPlatoes();
            }
        }

    }
}
