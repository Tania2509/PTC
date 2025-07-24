namespace Vistas.Formularios
{
    partial class frmDashboardAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardAdministrador));
            this.btnTrabajador = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCentralAdmin = new System.Windows.Forms.Panel();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrabajador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajador.ForeColor = System.Drawing.Color.White;
            this.btnTrabajador.Location = new System.Drawing.Point(0, 223);
            this.btnTrabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Size = new System.Drawing.Size(217, 51);
            this.btnTrabajador.TabIndex = 4;
            this.btnTrabajador.Text = "Trabajador";
            this.btnTrabajador.UseVisualStyleBackColor = false;
            this.btnTrabajador.Click += new System.EventHandler(this.btnTrabajador_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(217, 497);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 81);
            this.panel6.TabIndex = 3;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(217, 223);
            this.pnlLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_19_214654;
            this.pictureBox1.Location = new System.Drawing.Point(31, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(217, 471);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 81);
            this.panel5.TabIndex = 3;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(0, 274);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(217, 51);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlPrincipal.Controls.Add(this.btnInventario);
            this.pnlPrincipal.Controls.Add(this.btnTrabajador);
            this.pnlPrincipal.Controls.Add(this.panel5);
            this.pnlPrincipal.Controls.Add(this.pnlLogo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(217, 578);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(217, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 64);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 64);
            this.panel4.TabIndex = 3;
            // 
            // pnlCentralAdmin
            // 
            this.pnlCentralAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCentralAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralAdmin.Location = new System.Drawing.Point(217, 64);
            this.pnlCentralAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCentralAdmin.Name = "pnlCentralAdmin";
            this.pnlCentralAdmin.Size = new System.Drawing.Size(756, 433);
            this.pnlCentralAdmin.TabIndex = 4;
            // 
            // frmDashboardAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(973, 578);
            this.Controls.Add(this.pnlCentralAdmin);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDashboardAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboardAdministrador_Load);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTrabajador;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlCentralAdmin;
    }
}