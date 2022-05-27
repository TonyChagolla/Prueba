namespace Prueba
{
    partial class ModificaSueldo
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSueldo = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nuevo Sueldo";
            // 
            // tbxSueldo
            // 
            this.tbxSueldo.Location = new System.Drawing.Point(12, 40);
            this.tbxSueldo.Name = "tbxSueldo";
            this.tbxSueldo.Size = new System.Drawing.Size(186, 22);
            this.tbxSueldo.TabIndex = 6;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(204, 16);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(43, 17);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(12, 12);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(186, 22);
            this.tbxLogin.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 68);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ModificaSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 104);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSueldo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.tbxLogin);
            this.Name = "ModificaSueldo";
            this.Text = "Modificar Sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSueldo;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Button btnGuardar;
    }
}