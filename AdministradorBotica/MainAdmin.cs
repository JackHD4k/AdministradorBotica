using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace AdministradorBotica
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection("Data Source = Z:/AdministradorBotica/AdministradorBotica/database.db");

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            panelInicial.Visible = true;
            panelAgregar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            panelInicial.Visible = false;
            panelAgregar.Visible = true;
            string select = "select * from producto";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvAgregar.DataSource = tabla;
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string title = "Desarrollador";
            string message = "Hecho por\n Joel Isaac Ramos cordova \n 962325551 \n joelramoscordova5@protonmail.com ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons);
        }
    }
}
