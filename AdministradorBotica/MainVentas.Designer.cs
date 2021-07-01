
namespace AdministradorBotica
{
    partial class MainVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainVentas));
            this.panelInventario = new System.Windows.Forms.Panel();
            this.txbVender = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAmpIn = new System.Windows.Forms.Button();
            this.btnAccIn = new System.Windows.Forms.Button();
            this.btnBazIn = new System.Windows.Forms.Button();
            this.btnJarIn = new System.Windows.Forms.Button();
            this.btnPasIn = new System.Windows.Forms.Button();
            this.dgvIn = new System.Windows.Forms.DataGridView();
            this.panelInicial = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxVentas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbGanancia = new System.Windows.Forms.TextBox();
            this.txbCompra = new System.Windows.Forms.TextBox();
            this.txbVenta = new System.Windows.Forms.TextBox();
            this.panelInventario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
            this.panelInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(103)))), ((int)(((byte)(117)))));
            this.panelInventario.Controls.Add(this.txbVenta);
            this.panelInventario.Controls.Add(this.txbCompra);
            this.panelInventario.Controls.Add(this.txbVender);
            this.panelInventario.Controls.Add(this.btnVender);
            this.panelInventario.Controls.Add(this.txbID);
            this.panelInventario.Controls.Add(this.label15);
            this.panelInventario.Controls.Add(this.btnBuscar);
            this.panelInventario.Controls.Add(this.txbBuscar);
            this.panelInventario.Controls.Add(this.label16);
            this.panelInventario.Controls.Add(this.groupBox2);
            this.panelInventario.Controls.Add(this.dgvIn);
            this.panelInventario.Location = new System.Drawing.Point(254, 12);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(934, 776);
            this.panelInventario.TabIndex = 22;
            // 
            // txbVender
            // 
            this.txbVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVender.Location = new System.Drawing.Point(763, 422);
            this.txbVender.Name = "txbVender";
            this.txbVender.Size = new System.Drawing.Size(158, 30);
            this.txbVender.TabIndex = 38;
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.Black;
            this.btnVender.Location = new System.Drawing.Point(596, 407);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(161, 61);
            this.btnVender.TabIndex = 37;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(244, 147);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(125, 30);
            this.txbID.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(95, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(706, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 61);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(244, 184);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(361, 30);
            this.txbBuscar.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(95, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "NOMBRE:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAmpIn);
            this.groupBox2.Controls.Add(this.btnAccIn);
            this.groupBox2.Controls.Add(this.btnBazIn);
            this.groupBox2.Controls.Add(this.btnJarIn);
            this.groupBox2.Controls.Add(this.btnPasIn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MOSTRAR";
            // 
            // btnAmpIn
            // 
            this.btnAmpIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpIn.ForeColor = System.Drawing.Color.Black;
            this.btnAmpIn.Location = new System.Drawing.Point(354, 29);
            this.btnAmpIn.Name = "btnAmpIn";
            this.btnAmpIn.Size = new System.Drawing.Size(161, 61);
            this.btnAmpIn.TabIndex = 25;
            this.btnAmpIn.Text = "AMPOLLAS";
            this.btnAmpIn.UseVisualStyleBackColor = true;
            this.btnAmpIn.Click += new System.EventHandler(this.btnAmpIn_Click);
            // 
            // btnAccIn
            // 
            this.btnAccIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccIn.ForeColor = System.Drawing.Color.Black;
            this.btnAccIn.Location = new System.Drawing.Point(521, 29);
            this.btnAccIn.Name = "btnAccIn";
            this.btnAccIn.Size = new System.Drawing.Size(161, 61);
            this.btnAccIn.TabIndex = 24;
            this.btnAccIn.Text = "ACCESORIOS";
            this.btnAccIn.UseVisualStyleBackColor = true;
            this.btnAccIn.Click += new System.EventHandler(this.btnAccIn_Click);
            // 
            // btnBazIn
            // 
            this.btnBazIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazIn.ForeColor = System.Drawing.Color.Black;
            this.btnBazIn.Location = new System.Drawing.Point(688, 29);
            this.btnBazIn.Name = "btnBazIn";
            this.btnBazIn.Size = new System.Drawing.Size(161, 61);
            this.btnBazIn.TabIndex = 23;
            this.btnBazIn.Text = "BAZAR";
            this.btnBazIn.UseVisualStyleBackColor = true;
            this.btnBazIn.Click += new System.EventHandler(this.btnBazIn_Click);
            // 
            // btnJarIn
            // 
            this.btnJarIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJarIn.ForeColor = System.Drawing.Color.Black;
            this.btnJarIn.Location = new System.Drawing.Point(187, 29);
            this.btnJarIn.Name = "btnJarIn";
            this.btnJarIn.Size = new System.Drawing.Size(161, 61);
            this.btnJarIn.TabIndex = 26;
            this.btnJarIn.Text = "JARABES";
            this.btnJarIn.UseVisualStyleBackColor = true;
            this.btnJarIn.Click += new System.EventHandler(this.btnJarIn_Click);
            // 
            // btnPasIn
            // 
            this.btnPasIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasIn.ForeColor = System.Drawing.Color.Black;
            this.btnPasIn.Location = new System.Drawing.Point(20, 29);
            this.btnPasIn.Name = "btnPasIn";
            this.btnPasIn.Size = new System.Drawing.Size(161, 61);
            this.btnPasIn.TabIndex = 21;
            this.btnPasIn.Text = "PASTILLAS";
            this.btnPasIn.UseVisualStyleBackColor = true;
            this.btnPasIn.Click += new System.EventHandler(this.btnPasIn_Click);
            // 
            // dgvIn
            // 
            this.dgvIn.AllowUserToAddRows = false;
            this.dgvIn.AllowUserToDeleteRows = false;
            this.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIn.Location = new System.Drawing.Point(0, 474);
            this.dgvIn.Name = "dgvIn";
            this.dgvIn.ReadOnly = true;
            this.dgvIn.Size = new System.Drawing.Size(931, 302);
            this.dgvIn.TabIndex = 0;
            this.dgvIn.SelectionChanged += new System.EventHandler(this.dgvIn_SelectionChanged);
            // 
            // panelInicial
            // 
            this.panelInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(103)))), ((int)(((byte)(117)))));
            this.panelInicial.Controls.Add(this.pictureBox2);
            this.panelInicial.Location = new System.Drawing.Point(254, 12);
            this.panelInicial.Name = "panelInicial";
            this.panelInicial.Size = new System.Drawing.Size(934, 776);
            this.panelInicial.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorBotica.Properties.Resources.logo_farma;
            this.pictureBox2.Location = new System.Drawing.Point(271, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AdministradorBotica.Properties.Resources.FondodeUsuario;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 776);
            this.panel1.TabIndex = 19;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.btnVentas.Location = new System.Drawing.Point(3, 314);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(236, 47);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.btnInventario.Location = new System.Drawing.Point(0, 261);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(236, 47);
            this.btnInventario.TabIndex = 9;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(150)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(95, 726);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soporte";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(-3, 683);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "_______________________________________________";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.btnSalir.Location = new System.Drawing.Point(0, 570);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(236, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(-3, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "_______________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENDEDOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(103)))), ((int)(((byte)(117)))));
            this.panelVenta.Controls.Add(this.txbGanancia);
            this.panelVenta.Controls.Add(this.label6);
            this.panelVenta.Controls.Add(this.lbxVentas);
            this.panelVenta.Controls.Add(this.label5);
            this.panelVenta.Location = new System.Drawing.Point(254, 12);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(934, 776);
            this.panelVenta.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "VENTAS DEL DÍA:";
            // 
            // lbxVentas
            // 
            this.lbxVentas.FormattingEnabled = true;
            this.lbxVentas.Location = new System.Drawing.Point(18, 83);
            this.lbxVentas.Name = "lbxVentas";
            this.lbxVentas.ScrollAlwaysVisible = true;
            this.lbxVentas.Size = new System.Drawing.Size(898, 147);
            this.lbxVentas.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(446, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "GANANCIAS DEL DÍA:";
            // 
            // txbGanancia
            // 
            this.txbGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGanancia.Location = new System.Drawing.Point(670, 261);
            this.txbGanancia.Name = "txbGanancia";
            this.txbGanancia.ReadOnly = true;
            this.txbGanancia.Size = new System.Drawing.Size(246, 30);
            this.txbGanancia.TabIndex = 27;
            // 
            // txbCompra
            // 
            this.txbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCompra.Location = new System.Drawing.Point(100, 278);
            this.txbCompra.Name = "txbCompra";
            this.txbCompra.Size = new System.Drawing.Size(102, 30);
            this.txbCompra.TabIndex = 41;
            // 
            // txbVenta
            // 
            this.txbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVenta.Location = new System.Drawing.Point(100, 318);
            this.txbVenta.Name = "txbVenta";
            this.txbVenta.Size = new System.Drawing.Size(102, 30);
            this.txbVenta.TabIndex = 42;
            // 
            // MainVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministradorBotica.Properties.Resources.FondodeUsuario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelVenta);
            this.Controls.Add(this.panelInventario);
            this.Controls.Add(this.panelInicial);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainVentas";
            this.Load += new System.EventHandler(this.MainVentas_Load);
            this.panelInventario.ResumeLayout(false);
            this.panelInventario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
            this.panelInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelVenta.ResumeLayout(false);
            this.panelVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAmpIn;
        private System.Windows.Forms.Button btnAccIn;
        private System.Windows.Forms.Button btnBazIn;
        private System.Windows.Forms.Button btnJarIn;
        private System.Windows.Forms.Button btnPasIn;
        private System.Windows.Forms.DataGridView dgvIn;
        private System.Windows.Forms.Panel panelInicial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbVender;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.ListBox lbxVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbGanancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbVenta;
        private System.Windows.Forms.TextBox txbCompra;
    }
}