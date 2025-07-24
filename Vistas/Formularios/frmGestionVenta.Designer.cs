namespace Vistas.Formularios
{
    partial class frmGestionVenta
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
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgvMostrarPro = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProducto.Location = new System.Drawing.Point(653, 35);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(145, 59);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // dgvMostrarPro
            // 
            this.dgvMostrarPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarPro.Location = new System.Drawing.Point(230, 137);
            this.dgvMostrarPro.Name = "dgvMostrarPro";
            this.dgvMostrarPro.RowHeadersWidth = 51;
            this.dgvMostrarPro.RowTemplate.Height = 24;
            this.dgvMostrarPro.Size = new System.Drawing.Size(611, 345);
            this.dgvMostrarPro.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(283, 35);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(145, 59);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // frmGestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvMostrarPro);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Name = "frmGestionInventario";
            this.Text = "frmGestionInventario";
            this.Load += new System.EventHandler(this.frmGestionInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgvMostrarPro;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}