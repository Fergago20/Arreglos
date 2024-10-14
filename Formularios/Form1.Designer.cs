namespace Arreglos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btmGuardar = new System.Windows.Forms.ToolStripButton();
            this.btmEliminar = new System.Windows.Forms.ToolStripButton();
            this.btmEditar = new System.Windows.Forms.ToolStripButton();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.dtgRegistro = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.gbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(165, 176);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(194, 72);
            this.tbDescripcion.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(165, 79);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(194, 20);
            this.tbId.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(165, 132);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(194, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(165, 275);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(194, 20);
            this.tbPrecio.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btmGuardar,
            this.btmEliminar,
            this.btmEditar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btmGuardar
            // 
            this.btmGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btmGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btmGuardar.Image")));
            this.btmGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(23, 22);
            this.btmGuardar.Text = "Guardar";
            this.btmGuardar.Click += new System.EventHandler(this.btmGuardar_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btmEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btmEliminar.Image")));
            this.btmEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(23, 22);
            this.btmEliminar.Text = "Editar";
            // 
            // btmEditar
            // 
            this.btmEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btmEditar.Image = ((System.Drawing.Image)(resources.GetObject("btmEditar.Image")));
            this.btmEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btmEditar.Name = "btmEditar";
            this.btmEditar.Size = new System.Drawing.Size(23, 22);
            this.btmEditar.Text = "Eliminar";
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.dtgRegistro);
            this.gbRegistro.Location = new System.Drawing.Point(79, 325);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(561, 148);
            this.gbRegistro.TabIndex = 10;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registros Guardados";
            // 
            // dtgRegistro
            // 
            this.dtgRegistro.AllowUserToAddRows = false;
            this.dtgRegistro.AllowUserToDeleteRows = false;
            this.dtgRegistro.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            this.dtgRegistro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistro.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRegistro.Location = new System.Drawing.Point(3, 16);
            this.dtgRegistro.Name = "dtgRegistro";
            this.dtgRegistro.ReadOnly = true;
            this.dtgRegistro.Size = new System.Drawing.Size(555, 129);
            this.dtgRegistro.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btmGuardar;
        private System.Windows.Forms.ToolStripButton btmEliminar;
        private System.Windows.Forms.ToolStripButton btmEditar;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.DataGridView dtgRegistro;
    }
}

