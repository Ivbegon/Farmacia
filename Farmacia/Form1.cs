using entidades;
using Negocio.Empleados;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        private EmpleadosNegocio empleadosNegocio;
        public Form1()
        {
            InitializeComponent();
            empleadosNegocio = new EmpleadosNegocio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = txtB_usuario.Text;

            string password = txtB_password.Text;

            try
            {
                Empleado empleadoLogin = empleadosNegocio.Login(login, password);
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(empleadoLogin);
                menuPrincipal.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al hacer login");
            }
        }
    }
}
