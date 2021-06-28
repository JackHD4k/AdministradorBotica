using System;
using System.Windows.Forms;

namespace AdministradorBotica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                string mac = macCall.GetMacAddresss();
                if (mac == "080027ADFB45")
                {
                    this.Hide();
                    Usuario usuario = new Usuario();
                    usuario.Show();
                }
                else
                {
                    MessageBox.Show("Esta computadora no está registrada porfavor comunicarse con el desarrollador");
                    this.Close();
                }
            }
        }
    }
}
