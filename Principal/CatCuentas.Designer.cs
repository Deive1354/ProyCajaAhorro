namespace Principal
{
    partial class CatCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatCuentas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpSalir = new System.Windows.Forms.ToolStripButton();
            this.OpAgregar = new System.Windows.Forms.ToolStripButton();
            this.OpModificar = new System.Windows.Forms.ToolStripButton();
            this.OpEliminar = new System.Windows.Forms.ToolStripButton();
            this.OpCancelar = new System.Windows.Forms.ToolStripButton();
            this.OpGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 0;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CatCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 495);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CatCuentas";
            this.Text = "CatCuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatCuentas_FormClosing);
            this.Load += new System.EventHandler(this.CatCuentas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}