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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void carnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente formulario = new frmCliente();
            formulario.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlato form = new frmPlato();
            form.Show();
        }

        private void pedidoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado form = new frmEmpleado();
            form.Show();
        }
    }
}
