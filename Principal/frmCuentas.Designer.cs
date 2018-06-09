namespace Principal
{
    partial class frmCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpAgregar = new System.Windows.Forms.ToolStripButton();
            this.OpModificar = new System.Windows.Forms.ToolStripButton();
            this.OpEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpCancelar = new System.Windows.Forms.ToolStripButton();
            this.OpGuardar = new System.Windows.Forms.ToolStripButton();
            this.NoCuenta = new System.Windows.Forms.Label();
            this.IdSocio = new System.Windows.Forms.Label();
            this.IdCuenta = new System.Windows.Forms.Label();
            this.MontoApertura = new System.Windows.Forms.Label();
            this.Depositos = new System.Windows.Forms.Label();
            this.Retiros = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.Label();
            this.FechaApertura = new System.Windows.Forms.Label();
            this.NoUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(748, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpSalir
            // 
            this.OpSalir.Image = ((System.Drawing.Image)(resources.GetObject("OpSalir.Image")));
            this.OpSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpSalir.Name = "OpSalir";
            this.OpSalir.Size = new System.Drawing.Size(49, 22);
            this.OpSalir.Text = "Salir";
            this.OpSalir.Click += new System.EventHandler(this.OpSalir_Click);
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
            this.OpEliminar.Click += new System.EventHandler(this.OpEliminar_Click);
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
            // 
            // OpGuardar
            // 
            this.OpGuardar.Enabled = false;
            this.OpGuardar.Image = ((System.Drawing.Image)(resources.GetObject("OpGuardar.Image")));
            this.OpGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpGuardar.Name = "OpGuardar";
            this.OpGuardar.Size = new System.Drawing.Size(69, 22);
            this.OpGuardar.Text = "Guardar";
            // 
            // NoCuenta
            // 
            this.NoCuenta.AutoSize = true;
            this.NoCuenta.Location = new System.Drawing.Point(79, 55);
            this.NoCuenta.Name = "NoCuenta";
            this.NoCuenta.Size = new System.Drawing.Size(61, 13);
            this.NoCuenta.TabIndex = 5;
            this.NoCuenta.Text = "No. Cuenta";
            // 
            // IdSocio
            // 
            this.IdSocio.AutoSize = true;
            this.IdSocio.Location = new System.Drawing.Point(79, 88);
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.Size = new System.Drawing.Size(43, 13);
            this.IdSocio.TabIndex = 6;
            this.IdSocio.Text = "IdSocio";
            // 
            // IdCuenta
            // 
            this.IdCuenta.AutoSize = true;
            this.IdCuenta.Location = new System.Drawing.Point(79, 123);
            this.IdCuenta.Name = "IdCuenta";
            this.IdCuenta.Size = new System.Drawing.Size(50, 13);
            this.IdCuenta.TabIndex = 7;
            this.IdCuenta.Text = "IdCuenta";
            // 
            // MontoApertura
            // 
            this.MontoApertura.AutoSize = true;
            this.MontoApertura.Location = new System.Drawing.Point(79, 156);
            this.MontoApertura.Name = "MontoApertura";
            this.MontoApertura.Size = new System.Drawing.Size(77, 13);
            this.MontoApertura.TabIndex = 8;
            this.MontoApertura.Text = "MontoApertura";
            // 
            // Depositos
            // 
            this.Depositos.AutoSize = true;
            this.Depositos.Location = new System.Drawing.Point(79, 192);
            this.Depositos.Name = "Depositos";
            this.Depositos.Size = new System.Drawing.Size(54, 13);
            this.Depositos.TabIndex = 9;
            this.Depositos.Text = "Depositos";
            // 
            // Retiros
            // 
            this.Retiros.AutoSize = true;
            this.Retiros.Location = new System.Drawing.Point(354, 55);
            this.Retiros.Name = "Retiros";
            this.Retiros.Size = new System.Drawing.Size(40, 13);
            this.Retiros.TabIndex = 10;
            this.Retiros.Text = "Retiros";
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Location = new System.Drawing.Point(360, 84);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(34, 13);
            this.Saldo.TabIndex = 11;
            this.Saldo.Text = "Saldo";
            // 
            // FechaApertura
            // 
            this.FechaApertura.AutoSize = true;
            this.FechaApertura.Location = new System.Drawing.Point(317, 119);
            this.FechaApertura.Name = "FechaApertura";
            this.FechaApertura.Size = new System.Drawing.Size(77, 13);
            this.FechaApertura.TabIndex = 12;
            this.FechaApertura.Text = "FechaApertura";
            // 
            // NoUsuario
            // 
            this.NoUsuario.AutoSize = true;
            this.NoUsuario.Location = new System.Drawing.Point(337, 156);
            this.NoUsuario.Name = "NoUsuario";
            this.NoUsuario.Size = new System.Drawing.Size(57, 13);
            this.NoUsuario.TabIndex = 13;
            this.NoUsuario.Text = "NoUsuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(168, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(168, 189);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(422, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(422, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(422, 112);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(422, 149);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NoUsuario);
            this.Controls.Add(this.FechaApertura);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.Retiros);
            this.Controls.Add(this.Depositos);
            this.Controls.Add(this.MontoApertura);
            this.Controls.Add(this.IdCuenta);
            this.Controls.Add(this.IdSocio);
            this.Controls.Add(this.NoCuenta);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label NoCuenta;
        private System.Windows.Forms.Label IdSocio;
        private System.Windows.Forms.Label IdCuenta;
        private System.Windows.Forms.Label MontoApertura;
        private System.Windows.Forms.Label Depositos;
        private System.Windows.Forms.Label Retiros;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Label FechaApertura;
        private System.Windows.Forms.Label NoUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}