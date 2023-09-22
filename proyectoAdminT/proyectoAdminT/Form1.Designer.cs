namespace proyectoAdminT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAdministrador = new MetroFramework.Controls.MetroGrid();
            this.dgvProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVirtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProceso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdministrador
            // 
            this.dgvAdministrador.AllowUserToResizeRows = false;
            this.dgvAdministrador.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdministrador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdministrador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lilly", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdministrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProceso,
            this.dgvID,
            this.dgvFisica,
            this.dgvVirtual,
            this.dgvCPU});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lilly", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdministrador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdministrador.EnableHeadersVisualStyles = false;
            this.dgvAdministrador.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAdministrador.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvAdministrador.Location = new System.Drawing.Point(23, 80);
            this.dgvAdministrador.Name = "dgvAdministrador";
            this.dgvAdministrador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdministrador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdministrador.RowHeadersWidth = 62;
            this.dgvAdministrador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdministrador.RowTemplate.Height = 28;
            this.dgvAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministrador.Size = new System.Drawing.Size(1005, 503);
            this.dgvAdministrador.TabIndex = 0;
            this.dgvAdministrador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAdministrador_CellContentClick);
            // 
            // dgvProceso
            // 
            this.dgvProceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProceso.HeaderText = "Procesos";
            this.dgvProceso.MinimumWidth = 8;
            this.dgvProceso.Name = "dgvProceso";
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 8;
            this.dgvID.Name = "dgvID";
            // 
            // dgvFisica
            // 
            this.dgvFisica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFisica.HeaderText = "Memoria Fisica";
            this.dgvFisica.MinimumWidth = 8;
            this.dgvFisica.Name = "dgvFisica";
            // 
            // dgvVirtual
            // 
            this.dgvVirtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvVirtual.HeaderText = "Memoria Virtual";
            this.dgvVirtual.MinimumWidth = 8;
            this.dgvVirtual.Name = "dgvVirtual";
            // 
            // dgvCPU
            // 
            this.dgvCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCPU.HeaderText = "CPU";
            this.dgvCPU.MinimumWidth = 8;
            this.dgvCPU.Name = "dgvCPU";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.Font = new System.Drawing.Font("Lilly", 10F, System.Drawing.FontStyle.Italic);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnActualizar.Location = new System.Drawing.Point(39, 602);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(200, 50);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDetener.Font = new System.Drawing.Font("Lilly", 10F, System.Drawing.FontStyle.Italic);
            this.btnDetener.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetener.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDetener.Location = new System.Drawing.Point(289, 602);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(200, 50);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Font = new System.Drawing.Font("Lilly", 10F, System.Drawing.FontStyle.Italic);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(738, 602);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtContador
            // 
            this.txtContador.AutoSize = true;
            this.txtContador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtContador.Font = new System.Drawing.Font("Lilly", 8F);
            this.txtContador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtContador.Location = new System.Drawing.Point(35, 664);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(56, 28);
            this.txtContador.TabIndex = 7;
            this.txtContador.Text = "label1";
            this.txtContador.Click += new System.EventHandler(this.txtContador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Lilly", 8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(697, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del Proceso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProceso
            // 
            this.txtProceso.AutoSize = true;
            this.txtProceso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtProceso.Font = new System.Drawing.Font("Lilly", 8F);
            this.txtProceso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtProceso.Location = new System.Drawing.Point(919, 655);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(26, 28);
            this.txtProceso.TabIndex = 9;
            this.txtProceso.Text = "0";
            this.txtProceso.Click += new System.EventHandler(this.txtProceso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 719);
            this.Controls.Add(this.txtProceso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvAdministrador);
            this.Name = "Form1";
            this.Text = "Administrador de Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvAdministrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVirtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCPU;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnSalir;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label txtContador;
        private System.Windows.Forms.Label txtProceso;
        private System.Windows.Forms.Label label1;
    }
}

