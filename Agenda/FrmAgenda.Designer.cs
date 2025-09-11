namespace Agenda
{
    partial class FrmAgenda
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dGVDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSEstado = new System.Windows.Forms.StatusStrip();
            this.tSSLabNumPersonas = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLActualizacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.mnSSalir = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatos)).BeginInit();
            this.sSEstado.SuspendLayout();
            this.mnSSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dGVDatos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.sSEstado);
            this.splitContainer1.Size = new System.Drawing.Size(1309, 410);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 0;
            // 
            // dGVDatos
            // 
            this.dGVDatos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVDatos.Location = new System.Drawing.Point(0, 0);
            this.dGVDatos.Name = "dGVDatos";
            this.dGVDatos.RowHeadersWidth = 62;
            this.dGVDatos.RowTemplate.Height = 28;
            this.dGVDatos.Size = new System.Drawing.Size(1309, 321);
            this.dGVDatos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido paterno";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido materno";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dirección";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Teléfono";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Correo";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // sSEstado
            // 
            this.sSEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sSEstado.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sSEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLabNumPersonas,
            this.tSSLActualizacion});
            this.sSEstado.Location = new System.Drawing.Point(0, 53);
            this.sSEstado.Name = "sSEstado";
            this.sSEstado.Size = new System.Drawing.Size(1309, 32);
            this.sSEstado.TabIndex = 0;
            this.sSEstado.Text = "statusStrip1";
            // 
            // tSSLabNumPersonas
            // 
            this.tSSLabNumPersonas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tSSLabNumPersonas.Name = "tSSLabNumPersonas";
            this.tSSLabNumPersonas.Size = new System.Drawing.Size(179, 25);
            this.tSSLabNumPersonas.Text = "toolStripStatusLabel1";
            // 
            // tSSLActualizacion
            // 
            this.tSSLActualizacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tSSLActualizacion.Name = "tSSLActualizacion";
            this.tSSLActualizacion.Size = new System.Drawing.Size(179, 25);
            this.tSSLActualizacion.Text = "toolStripStatusLabel1";
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Enabled = true;
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnSSalir
            // 
            this.mnSSalir.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnSSalir.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnSSalir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.mnSSalir.Location = new System.Drawing.Point(0, 0);
            this.mnSSalir.Name = "mnSSalir";
            this.mnSSalir.Size = new System.Drawing.Size(1309, 33);
            this.mnSSalir.TabIndex = 1;
            this.mnSSalir.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 443);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mnSSalir);
            this.Name = "FrmAgenda";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatos)).EndInit();
            this.sSEstado.ResumeLayout(false);
            this.sSEstado.PerformLayout();
            this.mnSSalir.ResumeLayout(false);
            this.mnSSalir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dGVDatos;
        private System.Windows.Forms.StatusStrip sSEstado;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.ToolStripStatusLabel tSSLActualizacion;
        private System.Windows.Forms.ToolStripStatusLabel tSSLabNumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.MenuStrip mnSSalir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

