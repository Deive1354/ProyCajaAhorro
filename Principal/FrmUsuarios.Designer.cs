namespace Principal
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnodeusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuarios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lavell = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkactivo = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpAgregar = new System.Windows.Forms.ToolStripButton();
            this.OpModificar = new System.Windows.Forms.ToolStripButton();
            this.OpEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpCancelar = new System.Windows.Forms.ToolStripButton();
            this.OpGuardar = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-25, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 131);
            this.dataGridView1.TabIndex = 22;
            // 
            // txtnodeusuario
            // 
            this.txtnodeusuario.Location = new System.Drawing.Point(103, 103);
            this.txtnodeusuario.Name = "txtnodeusuario";
            this.txtnodeusuario.Size = new System.Drawing.Size(100, 20);
            this.txtnodeusuario.TabIndex = 21;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(103, 77);
            this.txtcontraseña.MaxLength = 32;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(197, 20);
            this.txtcontraseña.TabIndex = 20;
            // 
            // txtusuarios
            // 
            this.txtusuarios.Location = new System.Drawing.Point(103, 51);
            this.txtusuarios.Name = "txtusuarios";
            this.txtusuarios.Size = new System.Drawing.Size(100, 20);
            this.txtusuarios.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "No de usuario";
            // 
            // lavell
            // 
            this.lavell.AutoSize = true;
            this.lavell.Location = new System.Drawing.Point(24, 84);
            this.lavell.Name = "lavell";
            this.lavell.Size = new System.Drawing.Size(60, 13);
            this.lavell.TabIndex = 17;
            this.lavell.Text = "contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "activo";
            // 
            // checkactivo
            // 
            this.checkactivo.AutoSize = true;
            this.checkactivo.Location = new System.Drawing.Point(396, 44);
            this.checkactivo.Name = "checkactivo";
            this.checkactivo.Size = new System.Drawing.Size(15, 14);
            this.checkactivo.TabIndex = 14;
            this.checkactivo.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(579, 25);
            this.toolStrip1.TabIndex = 13;
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
            // 
            // OpGuardar
            // 
            this.OpGuardar.Enabled = false;
            this.OpGuardar.Image = ((System.Drawing.Image)(resources.GetObject("OpGuardar.Image")));
            this.OpGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpGuardar.Name = "OpGuardar";
            this.OpGuardar.Size = new System.Drawing.Size(69, 22);
            this.OpGuardar.Text = "Guardar";
            this.OpGuardar.Click += new System.EventHandler(this.OpGuardar_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnodeusuario);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lavell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkactivo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnodeusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lavell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkactivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton OpAgregar;
        private System.Windows.Forms.ToolStripButton OpModificar;
        private System.Windows.Forms.ToolStripButton OpEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton OpCancelar;
        private System.Windows.Forms.ToolStripButton OpGuardar;
        private System.Windows.Forms.Button button1;
    }
}