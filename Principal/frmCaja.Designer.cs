namespace Principal
{
    partial class frmCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaja));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpAgregar = new System.Windows.Forms.ToolStripButton();
            this.OpModificar = new System.Windows.Forms.ToolStripButton();
            this.OpEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpCancelar = new System.Windows.Forms.ToolStripButton();
            this.OpGuardar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.mvto = new System.Windows.Forms.Label();
            this.NoMvto = new System.Windows.Forms.TextBox();
            this.NoCu = new System.Windows.Forms.TextBox();
            this.cuenta = new System.Windows.Forms.Label();
            this.NoUsuario = new System.Windows.Forms.TextBox();
            this.Nusuario = new System.Windows.Forms.Label();
            this.SaldoInicial = new System.Windows.Forms.TextBox();
            this.SIni = new System.Windows.Forms.Label();
            this.Deposito = new System.Windows.Forms.TextBox();
            this.dep = new System.Windows.Forms.Label();
            this.Retiro = new System.Windows.Forms.TextBox();
            this.Ret = new System.Windows.Forms.Label();
            this.SaldFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpSalir,
            this.toolStripSeparator1,
            this.OpAgregar,
            this.OpModificar,
            this.OpEliminar,
            this.toolStripSeparator2,
            this.OpCancelar,
            this.OpGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";

            this.toolStrip1.Size = new System.Drawing.Size(789, 25);

            this.toolStrip1.Size = new System.Drawing.Size(852, 25);

            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpSalir
            // 
            this.OpSalir.Image = ((System.Drawing.Image)(resources.GetObject("OpSalir.Image")));
            this.OpSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpSalir.Name = "OpSalir";
            this.OpSalir.Size = new System.Drawing.Size(49, 22);
            this.OpSalir.Text = "Salir";
            this.OpSalir.Click += new System.EventHandler(this.OpSalir_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // OpAgregar
            // 
            this.OpAgregar.Image = ((System.Drawing.Image)(resources.GetObject("OpAgregar.Image")));
            this.OpAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpAgregar.Name = "OpAgregar";
            this.OpAgregar.Size = new System.Drawing.Size(69, 22);
            this.OpAgregar.Text = "Agregar";
            this.OpAgregar.Click += new System.EventHandler(this.OpAgregar_Click);
            // 
            // OpModificar
            // 
            this.OpModificar.Image = ((System.Drawing.Image)(resources.GetObject("OpModificar.Image")));
            this.OpModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpModificar.Name = "OpModificar";
            this.OpModificar.Size = new System.Drawing.Size(78, 22);
            this.OpModificar.Text = "Modificar";
            // 
            // OpEliminar
            // 
            this.OpEliminar.Image = ((System.Drawing.Image)(resources.GetObject("OpEliminar.Image")));
            this.OpEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpEliminar.Name = "OpEliminar";
            this.OpEliminar.Size = new System.Drawing.Size(70, 22);
            this.OpEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // OpCancelar
            // 
            this.OpCancelar.Enabled = false;
            this.OpCancelar.Image = ((System.Drawing.Image)(resources.GetObject("OpCancelar.Image")));
            this.OpCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpCancelar.Name = "OpCancelar";
            this.OpCancelar.Size = new System.Drawing.Size(73, 22);
            this.OpCancelar.Text = "Cancelar";
            this.OpCancelar.Click += new System.EventHandler(this.OpCancelar_Click);
            // 
            // OpGuardar
            // 
            this.OpGuardar.Enabled = false;
            this.OpGuardar.Image = ((System.Drawing.Image)(resources.GetObject("OpGuardar.Image")));
            this.OpGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpGuardar.Name = "OpGuardar";
            this.OpGuardar.Size = new System.Drawing.Size(69, 22);
            this.OpGuardar.Text = "Guardar";
            this.OpGuardar.Click += new System.EventHandler(this.OpGuardar_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(83, 192);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(591, 150);
            this.dataGridView4.TabIndex = 6;
            // 
            // mvto
            // 
            this.mvto.AutoSize = true;
            this.mvto.Location = new System.Drawing.Point(92, 47);
            this.mvto.Name = "mvto";
            this.mvto.Size = new System.Drawing.Size(51, 13);
            this.mvto.TabIndex = 7;
            this.mvto.Text = "No Mvto:";
            // 
            // NoMvto
            // 
            this.NoMvto.Location = new System.Drawing.Point(150, 47);
            this.NoMvto.Name = "NoMvto";
            this.NoMvto.Size = new System.Drawing.Size(100, 20);
            this.NoMvto.TabIndex = 8;
            // 
            // NoCu
            // 
            this.NoCu.Location = new System.Drawing.Point(150, 80);
            this.NoCu.Name = "NoCu";
            this.NoCu.Size = new System.Drawing.Size(100, 20);
            this.NoCu.TabIndex = 10;
            // 
            // cuenta
            // 
            this.cuenta.AutoSize = true;
            this.cuenta.Location = new System.Drawing.Point(82, 80);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(61, 13);
            this.cuenta.TabIndex = 9;
            this.cuenta.Text = "No Cuenta:";
            // 
            // NoUsuario
            // 
            this.NoUsuario.Location = new System.Drawing.Point(150, 125);
            this.NoUsuario.Name = "NoUsuario";
            this.NoUsuario.Size = new System.Drawing.Size(100, 20);
            this.NoUsuario.TabIndex = 12;
            // 
            // Nusuario
            // 
            this.Nusuario.AutoSize = true;
            this.Nusuario.Location = new System.Drawing.Point(80, 128);
            this.Nusuario.Name = "Nusuario";
            this.Nusuario.Size = new System.Drawing.Size(63, 13);
            this.Nusuario.TabIndex = 11;
            this.Nusuario.Text = "No Usuario:";
            // 
            // SaldoInicial
            // 
            this.SaldoInicial.Location = new System.Drawing.Point(354, 44);
            this.SaldoInicial.Name = "SaldoInicial";
            this.SaldoInicial.Size = new System.Drawing.Size(100, 20);
            this.SaldoInicial.TabIndex = 14;
            this.SaldoInicial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SIni
            // 
            this.SIni.AutoSize = true;
            this.SIni.Location = new System.Drawing.Point(271, 47);
            this.SIni.Name = "SIni";
            this.SIni.Size = new System.Drawing.Size(67, 13);
            this.SIni.TabIndex = 13;
            this.SIni.Text = "Saldo Inicial:";
            this.SIni.Click += new System.EventHandler(this.label1_Click);
            // 
            // Deposito
            // 
            this.Deposito.Location = new System.Drawing.Point(354, 77);
            this.Deposito.Name = "Deposito";
            this.Deposito.Size = new System.Drawing.Size(100, 20);
            this.Deposito.TabIndex = 16;
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Location = new System.Drawing.Point(286, 77);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(52, 13);
            this.dep.TabIndex = 15;
            this.dep.Text = "Deposito:";
            // 
            // Retiro
            // 
            this.Retiro.Location = new System.Drawing.Point(354, 112);
            this.Retiro.Name = "Retiro";
            this.Retiro.Size = new System.Drawing.Size(100, 20);
            this.Retiro.TabIndex = 18;
            // 
            // Ret
            // 
            this.Ret.AutoSize = true;
            this.Ret.Location = new System.Drawing.Point(286, 112);
            this.Ret.Name = "Ret";
            this.Ret.Size = new System.Drawing.Size(38, 13);
            this.Ret.TabIndex = 17;
            this.Ret.Text = "Retiro:";
            // 
            // SaldFin
            // 
            this.SaldFin.Location = new System.Drawing.Point(354, 138);
            this.SaldFin.Name = "SaldFin";
            this.SaldFin.Size = new System.Drawing.Size(100, 20);
            this.SaldFin.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Saldo Final:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(535, 44);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(82, 13);
            this.fecha.TabIndex = 22;
            this.fecha.Text = "Fecha de Mvto:";
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(789, 494);

            this.ClientSize = new System.Drawing.Size(852, 396);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SaldFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Retiro);
            this.Controls.Add(this.Ret);
            this.Controls.Add(this.Deposito);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.SaldoInicial);
            this.Controls.Add(this.SIni);
            this.Controls.Add(this.NoUsuario);
            this.Controls.Add(this.Nusuario);
            this.Controls.Add(this.NoCu);
            this.Controls.Add(this.cuenta);
            this.Controls.Add(this.NoMvto);
            this.Controls.Add(this.mvto);
            this.Controls.Add(this.dataGridView4);

            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCaja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.frmCaja_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton OpAgregar;
        private System.Windows.Forms.ToolStripButton OpModificar;
        private System.Windows.Forms.ToolStripButton OpEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton OpCancelar;
        private System.Windows.Forms.ToolStripButton OpGuardar;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label mvto;
        private System.Windows.Forms.TextBox NoMvto;
        private System.Windows.Forms.TextBox NoCu;
        private System.Windows.Forms.Label cuenta;
        private System.Windows.Forms.TextBox NoUsuario;
        private System.Windows.Forms.Label Nusuario;
        private System.Windows.Forms.TextBox SaldoInicial;
        private System.Windows.Forms.Label SIni;
        private System.Windows.Forms.TextBox Deposito;
        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.TextBox Retiro;
        private System.Windows.Forms.Label Ret;
        private System.Windows.Forms.TextBox SaldFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fecha;

    }
}