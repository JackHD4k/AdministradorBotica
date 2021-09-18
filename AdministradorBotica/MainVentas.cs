using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AdministradorBotica
{
    public partial class MainVentas : Form
    {
        private string a;
        private decimal balance = 0;
        private decimal c;

        private decimal precioventa = 0;
        private string d;
        private decimal f;

        public MainVentas()
        {
            InitializeComponent();
        }

        private SQLiteConnection con = new SQLiteConnection("Data Source = C:/Users/Joel/Documents/database.db");

        private void MainVentas_Load(object sender, System.EventArgs e)
        {
            panelInicial.Visible = true;
            panelInventario.Visible = false;
            panelVenta.Visible = false;
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            string title = "Salir";
            string message = "Esta seguro que desea salir?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //No procede con la limpieza
            }
        }

        private void label4_Click(object sender, System.EventArgs e)
        {
            string title = "Desarrollador";
            string message = "Hecho por\n Joel Isaac Ramos Cordova \n 962325551 \n joelramoscordova5@protonmail.com ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons);
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE NOM_PRO like '" + txbBuscar.Text + "%'";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
            con.Close();
        }

        private void btnPasIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 1";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnJarIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 2";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnAmpIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 3";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnAccIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 4";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnBazIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 5";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelInicial.Visible = false;
            panelInventario.Visible = true;
            panelVenta.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelInicial.Visible = false;
            panelInventario.Visible = false;
            panelVenta.Visible = true;
        }

        private void dgvIn_SelectionChanged(object sender, EventArgs e)
        {
            txbID.Text = dgvIn.Rows[dgvIn.CurrentCellAddress.Y].Cells[0].Value.ToString();
            txbBuscar.Text = dgvIn.Rows[dgvIn.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string title = "Vender";
            string message = "Esta seguro de que desea vender este producto?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                var cmd = new SQLiteCommand(con);
                con.Open();
                cmd.CommandText = "update PRODUCTO set STO_PRO = STO_PRO -'" + txbVender.Text + "'  where ID_PRO = '" + txbID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                
                txbGanancia.Text = "S/ " + ganancias().ToString();
                txbVenVen.Text = "S/ " + ventatotal().ToString();
                
                lbxVentas.Items.Add("PRODUCTO -> " + txbBuscar.Text + " + CANTIDAD -> " + txbVender.Text);

            }
            else
            {
                // No procede con la venta
            }
        }

        private decimal ganancias()
        {
            con.Open();
            string query = "SELECT (PVE_PRO - PCO_PRO) * '" + txbVender.Text + "' AS VENTAS FROM PRODUCTO WHERE ID_PRO = '" + txbID.Text + "'";
            SQLiteCommand slc = new SQLiteCommand(query, con);
            SQLiteDataReader dr = slc.ExecuteReader();
            while (dr.Read())
            {
                a = dr["ventas"].ToString();
                c = Convert.ToDecimal(a);
                balance += c;
            }
            con.Close();
            return balance;
        }

        private decimal ventatotal()
        {
            con.Open();
            string query = "SELECT PVE_PRO * '"+ txbVender.Text +"'  AS VENTAS FROM PRODUCTO WHERE ID_PRO = '" + txbID.Text + "'";
            SQLiteCommand slc = new SQLiteCommand(query, con);
            SQLiteDataReader dr = slc.ExecuteReader();
            while (dr.Read())
            {
                d = dr["ventas"].ToString();
                f = Convert.ToDecimal(d);
                precioventa += f;
            }
            con.Close();
            return precioventa;
        }

        private void lbxVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpiarVen_Click(object sender, EventArgs e)
        {
            string title = "Finalizar";
            string message = "Esta seguro de que desea limpiar?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                lbxVentas.Items.Clear();
                txbGanancia.Clear();
                txbVenVen.Clear();
                balance = 0;
                precioventa = 0;
            }
            else
            {
                //No procede con la limpieza
            }
        }
    }
}