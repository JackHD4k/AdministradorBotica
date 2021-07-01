using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AdministradorBotica
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private SQLiteConnection con = new SQLiteConnection("Data Source = Z:/AdministradorBotica/AdministradorBotica/database.db");

        private void btnCerrarSesion_Click(object sender, EventArgs e)
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

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            panelInicial.Visible = true;
            panelAgregar.Visible = false;
            panelEli.Visible = false;
            panelInventario.Visible = false;
            panelStock.Visible = false;
            refrescartabla();
        }

        // Load del panel AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            panelInicial.Visible = false;
            panelAgregar.Visible = true;
            panelInventario.Visible = false;
            panelEli.Visible = false;
            panelStock.Visible = false;
            refrescartabla();
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string title = "Desarrollador";
            string message = "Hecho por\n Joel Isaac Ramos Cordova \n 962325551 \n joelramoscordova5@protonmail.com ";
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
        }

        private void refrescartabla()
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf('% .2f',PCO_PRO) as 'Precio de compra', printf('% .2f',PVE_PRO) as 'Precio de venta' from PRODUCTO";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvAgregar.DataSource = tabla;
            dgvIn.DataSource = tabla;
            dgvEliMod.DataSource = tabla;
            dgvStock.DataSource = tabla;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "insert into producto(NOM_PRO, MAR_PRO, STO_PRO, PVE_PRO, PCO_PRO, ID_CAT) values ('" + txbNombre.Text + "', '" + txbMarca.Text + "', '" + txbStock.Text + "', '" + txbVenta.Text + "', '" + txbCompra.Text + "', 4)";
            cmd.ExecuteNonQuery();
            refrescartabla();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "insert into producto(NOM_PRO, MAR_PRO, STO_PRO, PVE_PRO, PCO_PRO, ID_CAT) values ('" + txbNombre.Text + "', '" + txbMarca.Text + "', '" + txbStock.Text + "', '" + txbVenta.Text + "', '" + txbCompra.Text + "', 1)";
            cmd.ExecuteNonQuery();
            refrescartabla();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "insert into producto(NOM_PRO, MAR_PRO, STO_PRO, PVE_PRO, PCO_PRO, ID_CAT) values ('" + txbNombre.Text + "', '" + txbMarca.Text + "', '" + txbStock.Text + "', '" + txbVenta.Text + "', '" + txbCompra.Text + "', 2)";
            cmd.ExecuteNonQuery();
            refrescartabla();
            con.Close();
        }

        private void btnAmpollas_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "insert into producto(NOM_PRO, MAR_PRO, STO_PRO, PVE_PRO, PCO_PRO, ID_CAT) values ('" + txbNombre.Text + "', '" + txbMarca.Text + "', '" + txbStock.Text + "', '" + txbVenta.Text + "', '" + txbCompra.Text + "', 3)";
            cmd.ExecuteNonQuery();
            refrescartabla();
            con.Close();
        }

        private void btnBazar_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "insert into producto(NOM_PRO, MAR_PRO, STO_PRO, PVE_PRO, PCO_PRO, ID_CAT) values ('" + txbNombre.Text + "', '" + txbMarca.Text + "', '" + txbStock.Text + "', '" + txbVenta.Text + "', '" + txbCompra.Text + "', 5)";
            cmd.ExecuteNonQuery();
            refrescartabla();
            con.Close();
        }

        // Load del panel Inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            con.Open();
            panelInicial.Visible = false;
            panelAgregar.Visible = false;
            panelInventario.Visible = true;
            panelEli.Visible = false;
            panelStock.Visible = false;
            refrescartabla();
            con.Close();
        }

        private void btnPasIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 1";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnJarIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 2";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnAmpIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 3";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnAccIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 4";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        private void btnBazIn_Click(object sender, EventArgs e)
        {
            string select = "SELECT NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 5";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
        }

        // Load del panel Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            panelInicial.Visible = false;
            panelAgregar.Visible = false;
            panelInventario.Visible = false;
            panelEli.Visible = true;
            panelStock.Visible = false;
            refrescartabla();
            con.Close();
        }

        private void btnPasEli_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 1";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvEliMod.DataSource = tabla;
        }

        private void btnJarEli_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 2";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvEliMod.DataSource = tabla;
        }

        private void btnAmpEli_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 3";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvEliMod.DataSource = tabla;
        }

        private void btnAccEli_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 4";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvEliMod.DataSource = tabla;
        }

        private void btnBazEli_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 5";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvEliMod.DataSource = tabla;
        }

        private void dgvEliMod_SelectionChanged(object sender, EventArgs e)
        {
            txbIDEli.Text = dgvEliMod.Rows[dgvEliMod.CurrentCellAddress.Y].Cells[0].Value.ToString();
            txbNombreEli.Text = dgvEliMod.Rows[dgvEliMod.CurrentCellAddress.Y].Cells[1].Value.ToString();
            txbMarcaEli.Text = dgvEliMod.Rows[dgvEliMod.CurrentCellAddress.Y].Cells[2].Value.ToString();
            txbStoEli.Text = dgvEliMod.Rows[dgvEliMod.CurrentCellAddress.Y].Cells[3].Value.ToString();
            txbVenEli.Text = dgvEliMod.Rows[dgvEliMod.CurrentCellAddress.Y].Cells[4].Value.ToString();
            txbComEli.Text = dgvEliMod.Rows[dgvEliMod.CurrentCellAddress.Y].Cells[5].Value.ToString();
        }

        private void btnEliminarEli_Click(object sender, EventArgs e)
        {
            string title = "Eliminar";
            string message = "Esta seguro de que desea eliminar este elemento?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                var cmd = new SQLiteCommand(con);
                con.Open();
                cmd.CommandText = "delete from PRODUCTO where ID_PRO = '" + txbIDEli.Text + "'";
                cmd.ExecuteNonQuery();
                refrescartabla();
                con.Close();
            }
            else
            {
                // No procede con la eliminación
            }
        }

        private void btnModificarEli_Click(object sender, EventArgs e)
        {
            string title = "Modificar";
            string message = "Esta seguro de que desea modificar este elemento?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                var cmd = new SQLiteCommand(con);
                con.Open();
                cmd.CommandText = "update producto set NOM_PRO = '" + txbNombreEli.Text + "', MAR_PRO = '" + txbMarcaEli.Text + "', STO_PRO = '" + txbStoEli.Text + "', PVE_PRO = '" + txbVenEli.Text + "', PCO_PRO = '" + txbComEli.Text + "' where ID_PRO = '" + txbIDEli.Text + "'";
                cmd.ExecuteNonQuery();
                refrescartabla();
                con.Close();
            }
            else
            {
                // No procede con la modificación
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            string select = "SELECT NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE NOM_PRO like '" + txbBuscar.Text + "%'";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvIn.DataSource = tabla;
            con.Close();
        }

        private void txbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnBuscar_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            panelInicial.Visible = false;
            panelAgregar.Visible = false;
            panelInventario.Visible = false;
            panelEli.Visible = false;
            panelStock.Visible = true;
            refrescartabla();
            con.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 1";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvStock.DataSource = tabla;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 2";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvStock.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 3";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvStock.DataSource = tabla;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 4";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvStock.DataSource = tabla;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE ID_CAT = 5";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvStock.DataSource = tabla;
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            string select = "SELECT ID_PRO as ID, NOM_PRO as NOMBRE, MAR_PRO AS MARCA, STO_PRO AS STOCK, printf(' % .2f', PCO_PRO) as 'Precio de compra', printf(' % .2f', PVE_PRO) as 'Precio de venta' from PRODUCTO WHERE NOM_PRO like '" + txbNomSto.Text + "%'";
            SQLiteDataAdapter adb = new SQLiteDataAdapter(select, con);
            DataTable tabla = new DataTable();
            adb.Fill(tabla);
            dgvStock.DataSource = tabla;
            con.Close();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
        }

        private void btnAgrSto_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "UPDATE PRODUCTO SET STO_PRO = STO_PRO + '" + txbAgrSto.Text + "' WHERE ID_PRO = '" + txbIdSto.Text + "'";
            cmd.ExecuteNonQuery();
            refrescartabla();
            con.Close();
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            txbIdSto.Text = dgvStock.Rows[dgvStock.CurrentCellAddress.Y].Cells[0].Value.ToString();
            txbNomSto.Text = dgvStock.Rows[dgvStock.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }

        private void dgvIn_SelectionChanged(object sender, EventArgs e)
        {
            txbBuscar.Text = dgvIn.Rows[dgvIn.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }
    }
}