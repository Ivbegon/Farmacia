using entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmMenuPrincipal: Form
    {
        private Empleado empleado;
        public frmMenuPrincipal(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            //this.WindowState = FormWindowState.Normal;
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            frmMedicamentos form = new frmMedicamentos();
            form.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas form = new frmVentas();
            form.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes form = new frmInformes();
            form.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
