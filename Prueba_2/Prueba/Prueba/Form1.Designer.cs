namespace Prueba
{
    partial class Main
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
            this.btnCrearCSV = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarSueldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearCSV
            // 
            this.btnCrearCSV.Location = new System.Drawing.Point(13, 13);
            this.btnCrearCSV.Name = "btnCrearCSV";
            this.btnCrearCSV.Size = new System.Drawing.Size(117, 28);
            this.btnCrearCSV.TabIndex = 1;
            this.btnCrearCSV.Text = "Crear CSV";
            this.btnCrearCSV.UseVisualStyleBackColor = true;
            this.btnCrearCSV.Click += new System.EventHandler(this.btnCrearCSV_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 47);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(776, 257);
            this.dgvMain.TabIndex = 2;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(137, 13);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(116, 28);
            this.btnAgregarUsuario.TabIndex = 3;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificarSueldo
            // 
            this.btnModificarSueldo.Location = new System.Drawing.Point(260, 13);
            this.btnModificarSueldo.Name = "btnModificarSueldo";
            this.btnModificarSueldo.Size = new System.Drawing.Size(206, 28);
            this.btnModificarSueldo.TabIndex = 4;
            this.btnModificarSueldo.Text = "Modificar Sueldo Usuario";
            this.btnModificarSueldo.UseVisualStyleBackColor = true;
            this.btnModificarSueldo.Click += new System.EventHandler(this.btnModificarSueldo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.btnModificarSueldo);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnCrearCSV);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Main";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCrearCSV;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificarSueldo;
    }
}

