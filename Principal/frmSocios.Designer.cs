namespace Principal
{
    partial class frmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpAgregar = new System.Windows.Forms.ToolStripButton();
            this.OpModificar = new System.Windows.Forms.ToolStripButton();
            this.OpEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpCancelar = new System.Windows.Forms.ToolStripButton();
            this.OpGuardar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Activo = new System.Windows.Forms.CheckBox();
            this.Buro = new System.Windows.Forms.CheckBox();
            this.txtSocio = new System.Windows.Forms.TextBox();
            this.rfc = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
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
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 1;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 243);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Socio";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rfc";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Domicilio";
            this.label3.Visible = false;
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Checked = true;
            this.Activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Activo.Location = new System.Drawing.Point(281, 71);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(56, 17);
            this.Activo.TabIndex = 6;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = true;
            this.Activo.Visible = false;
            // 
            // Buro
            // 
            this.Buro.AutoSize = true;
            this.Buro.Location = new System.Drawing.Point(281, 99);
            this.Buro.Name = "Buro";
            this.Buro.Size = new System.Drawing.Size(99, 17);
            this.Buro.TabIndex = 7;
            this.Buro.Text = "Buro de Credito";
            this.Buro.UseVisualStyleBackColor = true;
            this.Buro.Visible = false;
            // 
            // txtSocio
            // 
            this.txtSocio.Location = new System.Drawing.Point(121, 68);
            this.txtSocio.MaxLength = 120;
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(141, 20);
            this.txtSocio.TabIndex = 8;
            this.txtSocio.Text = "324534345345";
            this.txtSocio.Visible = false;
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(121, 92);
            this.rfc.MaxLength = 13;
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(141, 20);
            this.rfc.TabIndex = 9;
            this.rfc.Visible = false;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(121, 119);
            this.domicilio.MaxLength = 120;
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(141, 20);
            this.domicilio.TabIndex = 10;
            this.domicilio.Visible = false;
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 572);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.rfc);
            this.Controls.Add(this.txtSocio);
            this.Controls.Add(this.Buro);
            this.Controls.Add(this.Activo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSocios";
            this.Text = "Socios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Socios_FormClosing);
            this.Load += new System.EventHandler(this.Socios_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Activo;
        private System.Windows.Forms.CheckBox Buro;
        private System.Windows.Forms.TextBox txtSocio;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.TextBox domicilio;

    }
}