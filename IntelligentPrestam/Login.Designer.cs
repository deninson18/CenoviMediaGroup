namespace IntelligentPrestam
{
    partial class Login
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
            this.ContrasenaLtextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accesoUserbutton = new System.Windows.Forms.Button();
            this.SalirUserbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContrasenaLtextBox
            // 
            this.ContrasenaLtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaLtextBox.Location = new System.Drawing.Point(96, 140);
            this.ContrasenaLtextBox.Multiline = true;
            this.ContrasenaLtextBox.Name = "ContrasenaLtextBox";
            this.ContrasenaLtextBox.PasswordChar = '*';
            this.ContrasenaLtextBox.Size = new System.Drawing.Size(291, 35);
            this.ContrasenaLtextBox.TabIndex = 1;
            // 
            // UsuarioLtextBox
            // 
            this.UsuarioLtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLtextBox.Location = new System.Drawing.Point(96, 48);
            this.UsuarioLtextBox.Multiline = true;
            this.UsuarioLtextBox.Name = "UsuarioLtextBox";
            this.UsuarioLtextBox.Size = new System.Drawing.Size(291, 35);
            this.UsuarioLtextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // accesoUserbutton
            // 
            this.accesoUserbutton.Location = new System.Drawing.Point(99, 231);
            this.accesoUserbutton.Name = "accesoUserbutton";
            this.accesoUserbutton.Size = new System.Drawing.Size(137, 35);
            this.accesoUserbutton.TabIndex = 2;
            this.accesoUserbutton.Text = "ACCESO";
            this.accesoUserbutton.UseVisualStyleBackColor = true;
            this.accesoUserbutton.Click += new System.EventHandler(this.accesoUserbutton_Click);
            // 
            // SalirUserbutton
            // 
            this.SalirUserbutton.Location = new System.Drawing.Point(250, 231);
            this.SalirUserbutton.Name = "SalirUserbutton";
            this.SalirUserbutton.Size = new System.Drawing.Size(137, 35);
            this.SalirUserbutton.TabIndex = 3;
            this.SalirUserbutton.Text = "SALIR";
            this.SalirUserbutton.UseVisualStyleBackColor = true;
            this.SalirUserbutton.Click += new System.EventHandler(this.SalirUserbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 330);
            this.Controls.Add(this.SalirUserbutton);
            this.Controls.Add(this.accesoUserbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioLtextBox);
            this.Controls.Add(this.ContrasenaLtextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ContrasenaLtextBox;
        private System.Windows.Forms.TextBox UsuarioLtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accesoUserbutton;
        private System.Windows.Forms.Button SalirUserbutton;
    }
}