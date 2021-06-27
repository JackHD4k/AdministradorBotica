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
            refrescartabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Load del panel AGREGAR
            con.Open();
            panelInicial.Visible = false;
            panelAgregar.Visible = true;
            string select = "select * from producto";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvAgregar.DataSource = tabla;

            //Mostrar en combo box
            cmbCategoria.Items.Clear();
            string cate = "select nom_cat from categoria";
            SQLiteCommand sql = new SQLiteCommand(cate,con);
            sql.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
            da.Fill(dt);
            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "nom_cat";
            cmbCategoria.SelectedIndex = 0;
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string title = "Desarrollador";
            string message = "Hecho por\n Joel Isaac Ramos cordova \n 962325551 \n joelramoscordova5@protonmail.com ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons);
        }

        private void btnLimpiarPanel_Click(object sender, EventArgs e)
        {
            txbNombre.Clear();
            txbMarca.Clear();
            txbStock.Clear();
            txbCompra.Clear();
            txbVenta.Clear();
        }

        private void btnAgregarPanel_Click(object sender, EventArgs e)
        {   
            var cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "insert into producto(NOM_PRO, MAR_PRO, STO_PRO, PVE_PRO, PCO_PRO, ID_CAT) values ('" + txbNombre.Text + "', '" + txbMarca.Text + "', '" + txbStock.Text + "', '" + txbVenta.Text + "', '" + txbCompra.Text + "', 1)";
            cmd.ExecuteNonQuery();
            refrescartabla();
            con.Close();
        }
        private void refrescartabla()
        {
            string select = "select * from producto";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvAgregar.DataSource = tabla;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
