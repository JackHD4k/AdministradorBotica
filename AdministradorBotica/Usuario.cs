using System;
using System.Windows.Forms;

namespace AdministradorBotica
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Quiere salir del programa?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (r == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            const string passadmin = "1290";
            const string passventas = "1234";
            switch (txbContraseña.Text)
            {
                case passadmin:
                    this.Hide();
                    MainAdmin mainadmin = new MainAdmin();
                    mainadmin.Show();
                    break;
                case passventas:
                    this.Hide();
                    MainVentas mainventas = new MainVentas();
                    mainventas.Show();
                    break;
                default:
                    MessageBox.Show("Contraseña Incorrecta");
                    break;
            }
        }

        private void txbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnIngresar_Click(sender, e);
            }
        }
    }
}
